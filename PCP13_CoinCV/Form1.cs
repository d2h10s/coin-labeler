using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.Blob;
using OpenCvSharp.UserInterface;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace PCP13_CoinCV
{
    public partial class Form1 : Form
    {
        private void btn_Help_Click(object sender, EventArgs e)
        {
            string st =
@"기시디 4학년 19110015 최호승

이 프로그램은 10원, 50원, 100원, 500원의 동전이 모두 사진 내에 있다는 가정 하에 만들어졌습니다.

초점거리는 중요하지 않도록 알고리즘을 만들었지만, 수평 여부와 동전 크기의 균일성은 중요합니다.

최종 목표인 Calculate를 클릭하기 위해 Binary, Contour 버튼을 미리 클릭할 필요가 없습니다.

Camera 버튼을 누를 시 캠이 활성화되고 On 글씨의 색갈이 토글됩니다.

Show Origin Picture를 누르게되면 변환되지 않은 원본 이미지를 볼 수 있습니다.

Binary Threshold는 이진화의 임계값을 의미합니다.

Contour Length Threshold는 컨투어 작동 시 검출되는 라인의 최소 길이를 의미합니다.

Classifiy Threshold는 동전을 분류하는 기준이되는 사이즈의 배수를 의미합니다.

 ex) 1.08 => 10원짜리 동전의 1.08배보다 초과하는 동전은 50원짜리로 분류.
";
            tBox.AppendText(st);
        }
        Mat OriginIm, BinIm, GrayIm, ContourIm;
        List<OpenCvSharp.Point[]> Contours;
        VideoCapture gCap;
        int blink = 0; // to blink Cam Radio Button Text

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initial Image Setting
            //OriginIm = new Mat("Coin_1480.jpg");
            //pic.Image = OriginIm.ToBitmap();

            // Text Box Auto Scroll Setting
            tBox.Select(tBox.Text.Length, 0);
            tBox.ScrollToCaret();
            lbl_Class.Text = "1.08";
        }
        private void println(string st) // Write time and Task information in Text Box
        {
            tBox.AppendText(DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + " >> " + st + "\r\n");
        }

        private void btn_load_Click(object sender, EventArgs e) // File Load
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fname = openFileDialog.FileName;
                OriginIm = new Mat(fname);
                pic.Image = OriginIm.ToBitmap();
                println("Image is loaded");
            }
        }

        private void btn_Cam_Click(object sender, EventArgs e) // Camera On/Off Toggle
        {
            if (tim_Cam.Enabled == false)
            {
                int idxcam = 0;
                gCap = new VideoCapture(CaptureDevice.DShow, idxcam);

                // set resolution
                gCap.FrameWidth = 640;
                gCap.FrameHeight = 480;

                if (!gCap.IsOpened()) return;

                tim_Cam.Interval = 60;   // 60 frame/seconds to avoid flickering
                tim_Cam.Enabled = true;
                rad_On.Checked = true; // togle
                rad_Off.Checked = false; // togle
                println("Camera is On");
            }
            else
            {

                tim_Cam.Enabled = false;
                rad_Off.Checked = true; // togle
                rad_On.Checked = false; // togle
                rad_On.ForeColor = RadioButton.DefaultForeColor; // color toggle clear
                if (gCap != null) gCap.Dispose();
                println("Camera is Off");
            }
        }

        private void tim_Cam_Tick(object sender, EventArgs e) // Camera Timer
        {
            OriginIm = gCap.RetrieveMat();
            pic.Image = OriginIm.ToBitmap();
            if (blink++ % 2 == 0)   // color toggle
                rad_On.ForeColor = Color.Red;
            else
                rad_On.ForeColor = Color.Blue;
        }

        private void btn_Origin_Click(object sender, EventArgs e) // To See Original Image
        {
            if (OriginIm == null) // avoid null exception
            {
                println("Original Image is not exists");
                return;
            }
            pic.Image = OriginIm.ToBitmap();
            println("Image is set by Original");
        }

        private void btn_Bin_Click(object sender, EventArgs e) // Make Image to Binary
        {
            if (OriginIm == null)
            {
                println("Binarization failed, Please load image");
                return;
            }
            GrayIm = OriginIm.CvtColor(ColorConversionCodes.BGR2GRAY);
            if (rad_otsu.Checked) // otsu algorithm
            {
                BinIm = GrayIm.Threshold(0, 255, ThresholdTypes.Otsu);
                println("Image is set by Binary of otsu");
            }
            else // just in threshold
            {
                BinIm = GrayIm.Threshold(hsc_Bin.Value, 255, ThresholdTypes.Binary);
                println("Image is set by Binary " + hsc_Bin.Value.ToString());
                //BinIm = GrayIm.AdaptiveThreshold(255, AdaptiveThresholdTypes.GaussianC, ThresholdTypes.Binary, 25, 5);
            }
            pic.Image = BinIm.ToBitmap();
        }

        private void btn_Contour_Click(object sender, EventArgs e)
        {
            if(OriginIm == null)
            {
                println("Contour failed, Please load image");
                return;
            }
            println("Contour is executed ");
            btn_Bin.PerformClick();

            //Mat temp = new Mat(); // Save preprocessing Mat
            ContourIm = OriginIm.Clone(); // Save Contour Image
            OpenCvSharp.Point[][] initContours; // Save Contour Coordinate
            HierarchyIndex[] hierarchy; // Save Contour Hierarchies
            string st = "\r\n"; // Save Text Box Messages
            int i = 0; // Contour index number

            // make binary image in HSV color space
            // Cv2.InRange(BinIm, new Scalar(0, 127, 127), new Scalar(100, 255, 255), temp);

            // make contours
            Cv2.FindContours(BinIm, out initContours, out hierarchy, RetrievalModes.List, ContourApproximationModes.ApproxTC89KCOS);

            List<OpenCvSharp.Point[]> sortedContours = new List<OpenCvSharp.Point[]>();
            List<OpenCvSharp.Point[]> filteredContours = new List<OpenCvSharp.Point[]>();

            // sort contours in ascending order with delegate
            foreach (OpenCvSharp.Point[] p in initContours) sortedContours.Add(p);
            sortedContours.Sort(delegate (OpenCvSharp.Point[] a, OpenCvSharp.Point[] b)
            {
                return Cv2.ContourArea(a, true).CompareTo(Cv2.ContourArea(b, true));
            });

            // if contour lenth is shorter than set value, discard contour
            foreach (OpenCvSharp.Point[] p in sortedContours)
            {
                double len = Cv2.ArcLength(p, true);
                double area = Cv2.ContourArea(p, true);
                if (len > hsc_Len.Value && area > hsc_Area.Value)
                {
                    filteredContours.Add(p);
                    st += "             C" + (++i).ToString("D2") + ": Area = " + Math.Round(area).ToString() + "\r\n";
                }
            }

            println(st);
            // draw contours
            Cv2.DrawContours(ContourIm, filteredContours, -1, new Scalar(255, 0, 0), 20, LineTypes.AntiAlias, null, 9);
            pic.Image = ContourIm.ToBitmap();
            Contours = filteredContours;
        }

        private void btn_Default_Click(object sender, EventArgs e) // set threshold to default
        {
            hsc_Bin.Value = 127;
            hsc_Len.Value = 300;
            hsc_Area.Value = 200;
            hsc_Class.Value = 108;

            lbl_Bin.Text = 127.ToString();
            lbl_Len.Text = 300.ToString();
            lbl_Area.Text = 200.ToString();
            lbl_Class.Text = 1.08.ToString();
            if(OriginIm != null)
                pic.Image = OriginIm.ToBitmap();
        }

        private void btn_Cal_Click(object sender, EventArgs e)
        {
            if(OriginIm == null)
            {
                println("Calculate failed, Please load image");
                return;
            }
            DateTime start = DateTime.Now;
            btn_Contour.PerformClick();
            if (Contours.Count == 0) // avoid exception
            {
                println("Contour Failed, please readjust thresholds!");
                return;
            }
            int idx, class_idx = 0;
            string[] cname = { "10", "50", "100", "500" };
            List<OpenCvSharp.Point[]>[] classified = new List<OpenCvSharp.Point[]>[4];
            for (idx = 0; idx < 4; idx++) classified[idx] = new List<OpenCvSharp.Point[]>();

            classified[0].Add(Contours[0]); // minimum size is always class 0
            for (idx = 1; idx < Contours.Count; idx++)
            {
                // List Countours is already sored by area
                double a = Cv2.ContourArea(Contours[idx - 1], true);
                double b = Cv2.ContourArea(Contours[idx], true);
                if (a * (hsc_Class.Value / 100d) > b)
                    classified[class_idx % 4].Add(Contours[idx]); // avoid exception
                else
                {
                    classified[++class_idx % 4].Add(Contours[idx]);
                }
            }

            // Write classification at Centroid 
            for(class_idx = 0; class_idx < 4; class_idx++)
            {
                foreach(OpenCvSharp.Point[] p in classified[class_idx])
                {
                    Moments moments = Cv2.Moments(p, false);
                    int x = (int)(moments.M10 / moments.M00);
                    int y = (int)(moments.M01 / moments.M00);
                    //Cv2.Circle(ContourIm, x , y, 30, Scalar.Black, -1);
                    Cv2.PutText(ContourIm, cname[class_idx], new OpenCvSharp.Point(x, y), HersheyFonts.HersheyPlain, 10, new Scalar(0, 0, 255), 10, LineTypes.AntiAlias);
                }
            }
            pic.Image = ContourIm.ToBitmap();

            // calculate sum of coin in won
            int _10 = classified[0].Count;
            int _50 = classified[1].Count;
            int _100 = classified[2].Count;
            int _500 = classified[3].Count;
            int sum = _10 * 10 + _50 * 50 + _100 * 100 + _500 * 500;
            string st = "Coins are Classified\r\n";
            st += "class  10: " + _10.ToString("D2") + "\r\n";
            st += "class  50: " + _50.ToString("D2") + "\r\n";
            st += "class 100: " + _100.ToString("D2") + "\r\n";
            st += "class 500: " + _500.ToString("D2") + "\r\n";
            st += "All Coins is " + sum.ToString("C", CultureInfo.CurrentCulture);
            println(st + "\r\n\r\n" + DateTime.Now.Subtract(start).Milliseconds.ToString() + "ms is elapsed");
        }

        private void hsc_Bin_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_Bin.Text = hsc_Bin.Value.ToString();
            if (rad_scr.Checked) btn_Bin.PerformClick();
        }

        private void hsc_Len_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_Len.Text = hsc_Len.Value.ToString();
        }

        private void hsc_Area_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_Area.Text = hsc_Area.Value.ToString();
        }

        private void hsc_Class_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_Class.Text = Convert.ToString(hsc_Class.Value / 100d);
        }
    }
}
