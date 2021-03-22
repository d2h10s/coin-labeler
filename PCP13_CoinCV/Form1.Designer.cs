namespace PCP13_CoinCV
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_Bin = new System.Windows.Forms.Button();
            this.btn_Origin = new System.Windows.Forms.Button();
            this.btn_Cam = new System.Windows.Forms.Button();
            this.rad_On = new System.Windows.Forms.RadioButton();
            this.rad_Off = new System.Windows.Forms.RadioButton();
            this.tim_Cam = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hsc_Bin = new System.Windows.Forms.HScrollBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_otsu = new System.Windows.Forms.RadioButton();
            this.rad_scr = new System.Windows.Forms.RadioButton();
            this.btn_Contour = new System.Windows.Forms.Button();
            this.tBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hsc_Area = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.hsc_Len = new System.Windows.Forms.HScrollBar();
            this.lbl_Bin = new System.Windows.Forms.Label();
            this.lbl_Len = new System.Windows.Forms.Label();
            this.lbl_Area = new System.Windows.Forms.Label();
            this.btn_Default = new System.Windows.Forms.Button();
            this.btn_Cal = new System.Windows.Forms.Button();
            this.lbl_Class = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hsc_Class = new System.Windows.Forms.HScrollBar();
            this.btn_Help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Location = new System.Drawing.Point(12, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(640, 480);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_load.Location = new System.Drawing.Point(659, 13);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(92, 48);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btn_Bin
            // 
            this.btn_Bin.Location = new System.Drawing.Point(659, 67);
            this.btn_Bin.Name = "btn_Bin";
            this.btn_Bin.Size = new System.Drawing.Size(92, 48);
            this.btn_Bin.TabIndex = 2;
            this.btn_Bin.Text = "Binary";
            this.btn_Bin.UseVisualStyleBackColor = true;
            this.btn_Bin.Click += new System.EventHandler(this.btn_Bin_Click);
            // 
            // btn_Origin
            // 
            this.btn_Origin.Location = new System.Drawing.Point(915, 13);
            this.btn_Origin.Name = "btn_Origin";
            this.btn_Origin.Size = new System.Drawing.Size(95, 48);
            this.btn_Origin.TabIndex = 3;
            this.btn_Origin.Text = "Show Origin Picture";
            this.btn_Origin.UseVisualStyleBackColor = true;
            this.btn_Origin.Click += new System.EventHandler(this.btn_Origin_Click);
            // 
            // btn_Cam
            // 
            this.btn_Cam.Location = new System.Drawing.Point(757, 12);
            this.btn_Cam.Name = "btn_Cam";
            this.btn_Cam.Size = new System.Drawing.Size(93, 48);
            this.btn_Cam.TabIndex = 4;
            this.btn_Cam.Text = "Camera";
            this.btn_Cam.UseVisualStyleBackColor = true;
            this.btn_Cam.Click += new System.EventHandler(this.btn_Cam_Click);
            // 
            // rad_On
            // 
            this.rad_On.AutoCheck = false;
            this.rad_On.AutoSize = true;
            this.rad_On.Location = new System.Drawing.Point(6, 11);
            this.rad_On.Name = "rad_On";
            this.rad_On.Size = new System.Drawing.Size(39, 16);
            this.rad_On.TabIndex = 5;
            this.rad_On.Text = "On";
            this.rad_On.UseVisualStyleBackColor = true;
            // 
            // rad_Off
            // 
            this.rad_Off.AutoCheck = false;
            this.rad_Off.AutoSize = true;
            this.rad_Off.Checked = true;
            this.rad_Off.Location = new System.Drawing.Point(6, 33);
            this.rad_Off.Name = "rad_Off";
            this.rad_Off.Size = new System.Drawing.Size(38, 16);
            this.rad_Off.TabIndex = 6;
            this.rad_Off.TabStop = true;
            this.rad_Off.Text = "Off";
            this.rad_Off.UseVisualStyleBackColor = true;
            // 
            // tim_Cam
            // 
            this.tim_Cam.Tick += new System.EventHandler(this.tim_Cam_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_On);
            this.groupBox1.Controls.Add(this.rad_Off);
            this.groupBox1.Location = new System.Drawing.Point(856, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(53, 56);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // hsc_Bin
            // 
            this.hsc_Bin.Location = new System.Drawing.Point(827, 86);
            this.hsc_Bin.Maximum = 255;
            this.hsc_Bin.Name = "hsc_Bin";
            this.hsc_Bin.Size = new System.Drawing.Size(183, 24);
            this.hsc_Bin.TabIndex = 8;
            this.hsc_Bin.Value = 127;
            this.hsc_Bin.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsc_Bin_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_otsu);
            this.groupBox2.Controls.Add(this.rad_scr);
            this.groupBox2.Location = new System.Drawing.Point(757, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(67, 53);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // rad_otsu
            // 
            this.rad_otsu.AutoSize = true;
            this.rad_otsu.Checked = true;
            this.rad_otsu.Location = new System.Drawing.Point(6, 11);
            this.rad_otsu.Name = "rad_otsu";
            this.rad_otsu.Size = new System.Drawing.Size(49, 16);
            this.rad_otsu.TabIndex = 5;
            this.rad_otsu.TabStop = true;
            this.rad_otsu.Text = "Otsu";
            this.rad_otsu.UseVisualStyleBackColor = true;
            // 
            // rad_scr
            // 
            this.rad_scr.AutoSize = true;
            this.rad_scr.Location = new System.Drawing.Point(6, 26);
            this.rad_scr.Name = "rad_scr";
            this.rad_scr.Size = new System.Drawing.Size(55, 16);
            this.rad_scr.TabIndex = 6;
            this.rad_scr.Text = "Scroll";
            this.rad_scr.UseVisualStyleBackColor = true;
            // 
            // btn_Contour
            // 
            this.btn_Contour.Location = new System.Drawing.Point(659, 121);
            this.btn_Contour.Name = "btn_Contour";
            this.btn_Contour.Size = new System.Drawing.Size(92, 48);
            this.btn_Contour.TabIndex = 9;
            this.btn_Contour.Text = "Contour";
            this.btn_Contour.UseVisualStyleBackColor = true;
            this.btn_Contour.Click += new System.EventHandler(this.btn_Contour_Click);
            // 
            // tBox
            // 
            this.tBox.Location = new System.Drawing.Point(658, 296);
            this.tBox.Multiline = true;
            this.tBox.Name = "tBox";
            this.tBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBox.Size = new System.Drawing.Size(353, 196);
            this.tBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(830, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Binary Threshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contour Area Threshold";
            // 
            // hsc_Area
            // 
            this.hsc_Area.LargeChange = 100;
            this.hsc_Area.Location = new System.Drawing.Point(655, 232);
            this.hsc_Area.Maximum = 1001;
            this.hsc_Area.Name = "hsc_Area";
            this.hsc_Area.Size = new System.Drawing.Size(355, 19);
            this.hsc_Area.TabIndex = 13;
            this.hsc_Area.Value = 200;
            this.hsc_Area.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsc_Area_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "Contour Length Threshold";
            // 
            // hsc_Len
            // 
            this.hsc_Len.LargeChange = 100;
            this.hsc_Len.Location = new System.Drawing.Point(655, 189);
            this.hsc_Len.Maximum = 1001;
            this.hsc_Len.Name = "hsc_Len";
            this.hsc_Len.Size = new System.Drawing.Size(355, 19);
            this.hsc_Len.TabIndex = 15;
            this.hsc_Len.Value = 300;
            this.hsc_Len.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsc_Len_Scroll);
            // 
            // lbl_Bin
            // 
            this.lbl_Bin.AutoSize = true;
            this.lbl_Bin.Location = new System.Drawing.Point(987, 71);
            this.lbl_Bin.Name = "lbl_Bin";
            this.lbl_Bin.Size = new System.Drawing.Size(23, 12);
            this.lbl_Bin.TabIndex = 17;
            this.lbl_Bin.Text = "127";
            this.lbl_Bin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Len
            // 
            this.lbl_Len.AutoSize = true;
            this.lbl_Len.Location = new System.Drawing.Point(988, 177);
            this.lbl_Len.Name = "lbl_Len";
            this.lbl_Len.Size = new System.Drawing.Size(23, 12);
            this.lbl_Len.TabIndex = 18;
            this.lbl_Len.Text = "300";
            this.lbl_Len.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Area
            // 
            this.lbl_Area.AutoSize = true;
            this.lbl_Area.Location = new System.Drawing.Point(988, 220);
            this.lbl_Area.Name = "lbl_Area";
            this.lbl_Area.Size = new System.Drawing.Size(23, 12);
            this.lbl_Area.TabIndex = 19;
            this.lbl_Area.Text = "200";
            this.lbl_Area.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_Default
            // 
            this.btn_Default.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Default.Location = new System.Drawing.Point(850, 121);
            this.btn_Default.Name = "btn_Default";
            this.btn_Default.Size = new System.Drawing.Size(59, 48);
            this.btn_Default.TabIndex = 20;
            this.btn_Default.Text = "Set Default";
            this.btn_Default.UseVisualStyleBackColor = false;
            this.btn_Default.Click += new System.EventHandler(this.btn_Default_Click);
            // 
            // btn_Cal
            // 
            this.btn_Cal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Cal.Location = new System.Drawing.Point(757, 121);
            this.btn_Cal.Name = "btn_Cal";
            this.btn_Cal.Size = new System.Drawing.Size(87, 48);
            this.btn_Cal.TabIndex = 21;
            this.btn_Cal.Text = "Calculate";
            this.btn_Cal.UseVisualStyleBackColor = false;
            this.btn_Cal.Click += new System.EventHandler(this.btn_Cal_Click);
            // 
            // lbl_Class
            // 
            this.lbl_Class.AutoSize = true;
            this.lbl_Class.Location = new System.Drawing.Point(988, 262);
            this.lbl_Class.Name = "lbl_Class";
            this.lbl_Class.Size = new System.Drawing.Size(27, 12);
            this.lbl_Class.TabIndex = 24;
            this.lbl_Class.Text = "1.08";
            this.lbl_Class.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "Classifiy Threshold";
            // 
            // hsc_Class
            // 
            this.hsc_Class.LargeChange = 100;
            this.hsc_Class.Location = new System.Drawing.Point(655, 274);
            this.hsc_Class.Maximum = 1001;
            this.hsc_Class.Name = "hsc_Class";
            this.hsc_Class.Size = new System.Drawing.Size(355, 19);
            this.hsc_Class.TabIndex = 22;
            this.hsc_Class.Value = 108;
            this.hsc_Class.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsc_Class_Scroll);
            // 
            // btn_Help
            // 
            this.btn_Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Help.Location = new System.Drawing.Point(915, 121);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(95, 48);
            this.btn_Help.TabIndex = 25;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 508);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.lbl_Class);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hsc_Class);
            this.Controls.Add(this.btn_Cal);
            this.Controls.Add(this.btn_Default);
            this.Controls.Add(this.lbl_Area);
            this.Controls.Add(this.lbl_Len);
            this.Controls.Add(this.lbl_Bin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hsc_Len);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hsc_Area);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBox);
            this.Controls.Add(this.btn_Contour);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.hsc_Bin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Cam);
            this.Controls.Add(this.btn_Origin);
            this.Controls.Add(this.btn_Bin);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.pic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btn_Bin;
        private System.Windows.Forms.Button btn_Origin;
        private System.Windows.Forms.Button btn_Cam;
        private System.Windows.Forms.RadioButton rad_On;
        private System.Windows.Forms.RadioButton rad_Off;
        private System.Windows.Forms.Timer tim_Cam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.HScrollBar hsc_Bin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad_otsu;
        private System.Windows.Forms.RadioButton rad_scr;
        private System.Windows.Forms.Button btn_Contour;
        private System.Windows.Forms.TextBox tBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar hsc_Area;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar hsc_Len;
        private System.Windows.Forms.Label lbl_Bin;
        private System.Windows.Forms.Label lbl_Len;
        private System.Windows.Forms.Label lbl_Area;
        private System.Windows.Forms.Button btn_Default;
        private System.Windows.Forms.Button btn_Cal;
        private System.Windows.Forms.Label lbl_Class;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar hsc_Class;
        private System.Windows.Forms.Button btn_Help;
    }
}

