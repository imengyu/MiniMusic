namespace MusicPlayer
{
    partial class FormEq
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEq));
            this.eq1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eq2 = new System.Windows.Forms.TrackBar();
            this.eq4 = new System.Windows.Forms.TrackBar();
            this.eq3 = new System.Windows.Forms.TrackBar();
            this.eq6 = new System.Windows.Forms.TrackBar();
            this.eq5 = new System.Windows.Forms.TrackBar();
            this.eq8 = new System.Windows.Forms.TrackBar();
            this.eq7 = new System.Windows.Forms.TrackBar();
            this.eq10 = new System.Windows.Forms.TrackBar();
            this.eq9 = new System.Windows.Forms.TrackBar();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.layeredCheckButton1 = new LayeredSkin.Controls.LayeredCheckButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq9)).BeginInit();
            this.SuspendLayout();
            // 
            // eq1
            // 
            this.eq1.Location = new System.Drawing.Point(59, 29);
            this.eq1.Maximum = 12;
            this.eq1.Minimum = -12;
            this.eq1.Name = "eq1";
            this.eq1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq1.Size = new System.Drawing.Size(45, 183);
            this.eq1.TabIndex = 0;
            this.eq1.TickFrequency = 2;
            this.eq1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.eq1.Scroll += new System.EventHandler(this.eq1_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(332, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Rest";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "-12db-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "+12db-";
            // 
            // eq2
            // 
            this.eq2.Location = new System.Drawing.Point(110, 29);
            this.eq2.Maximum = 12;
            this.eq2.Minimum = -12;
            this.eq2.Name = "eq2";
            this.eq2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq2.Size = new System.Drawing.Size(45, 183);
            this.eq2.TabIndex = 6;
            this.eq2.TickFrequency = 2;
            this.eq2.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.eq2.Scroll += new System.EventHandler(this.eq2_Scroll);
            // 
            // eq4
            // 
            this.eq4.Location = new System.Drawing.Point(212, 29);
            this.eq4.Maximum = 12;
            this.eq4.Minimum = -12;
            this.eq4.Name = "eq4";
            this.eq4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq4.Size = new System.Drawing.Size(45, 183);
            this.eq4.TabIndex = 8;
            this.eq4.TickFrequency = 2;
            this.eq4.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.eq4.Scroll += new System.EventHandler(this.eq4_Scroll);
            // 
            // eq3
            // 
            this.eq3.Location = new System.Drawing.Point(161, 29);
            this.eq3.Maximum = 12;
            this.eq3.Minimum = -12;
            this.eq3.Name = "eq3";
            this.eq3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq3.Size = new System.Drawing.Size(45, 183);
            this.eq3.TabIndex = 7;
            this.eq3.TickFrequency = 2;
            this.eq3.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.eq3.Scroll += new System.EventHandler(this.eq3_Scroll);
            // 
            // eq6
            // 
            this.eq6.Location = new System.Drawing.Point(314, 29);
            this.eq6.Maximum = 12;
            this.eq6.Minimum = -12;
            this.eq6.Name = "eq6";
            this.eq6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq6.Size = new System.Drawing.Size(45, 183);
            this.eq6.TabIndex = 10;
            this.eq6.TickFrequency = 2;
            this.eq6.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.eq6.Scroll += new System.EventHandler(this.eq6_Scroll);
            // 
            // eq5
            // 
            this.eq5.Location = new System.Drawing.Point(263, 29);
            this.eq5.Maximum = 12;
            this.eq5.Minimum = -12;
            this.eq5.Name = "eq5";
            this.eq5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq5.Size = new System.Drawing.Size(45, 183);
            this.eq5.TabIndex = 9;
            this.eq5.TickFrequency = 2;
            this.eq5.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.eq5.Scroll += new System.EventHandler(this.eq5_Scroll);
            // 
            // eq8
            // 
            this.eq8.Location = new System.Drawing.Point(416, 29);
            this.eq8.Maximum = 12;
            this.eq8.Minimum = -12;
            this.eq8.Name = "eq8";
            this.eq8.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq8.Size = new System.Drawing.Size(45, 183);
            this.eq8.TabIndex = 12;
            this.eq8.TickFrequency = 2;
            this.eq8.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.eq8.Scroll += new System.EventHandler(this.eq8_Scroll);
            // 
            // eq7
            // 
            this.eq7.Location = new System.Drawing.Point(365, 29);
            this.eq7.Maximum = 12;
            this.eq7.Minimum = -12;
            this.eq7.Name = "eq7";
            this.eq7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq7.Size = new System.Drawing.Size(45, 183);
            this.eq7.TabIndex = 11;
            this.eq7.TickFrequency = 2;
            this.eq7.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.eq7.Scroll += new System.EventHandler(this.eq7_Scroll);
            // 
            // eq10
            // 
            this.eq10.Location = new System.Drawing.Point(518, 29);
            this.eq10.Maximum = 12;
            this.eq10.Minimum = -12;
            this.eq10.Name = "eq10";
            this.eq10.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq10.Size = new System.Drawing.Size(45, 183);
            this.eq10.TabIndex = 14;
            this.eq10.TickFrequency = 2;
            this.eq10.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.eq10.Scroll += new System.EventHandler(this.eq10_Scroll);
            // 
            // eq9
            // 
            this.eq9.Location = new System.Drawing.Point(467, 29);
            this.eq9.Maximum = 12;
            this.eq9.Minimum = -12;
            this.eq9.Name = "eq9";
            this.eq9.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.eq9.Size = new System.Drawing.Size(45, 183);
            this.eq9.TabIndex = 13;
            this.eq9.TickFrequency = 2;
            this.eq9.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.eq9.Scroll += new System.EventHandler(this.eq9_Scroll);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(12, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Choose VST Plugins";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(12, 237);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Choose DSP Plugins";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "Preset scheme:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "自定义",
            "默认",
            "古典",
            "俱乐部",
            "舞曲",
            "增强低音",
            "增强低音和高音",
            "增强高音",
            "耳机",
            "大厅",
            "现场",
            "派对",
            "流行",
            "瑞格",
            "摇滚",
            "斯卡",
            "温和",
            "温和摇摆",
            "电子"});
            this.comboBox1.Location = new System.Drawing.Point(413, 239);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 20);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(479, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "60      170     370      600      1k       3k      6k      12k      14k     15k";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "- 0 -";
            // 
            // layeredCheckButton1
            // 
            this.layeredCheckButton1.AdaptImage = true;
            this.layeredCheckButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredCheckButton1.BaseColor = System.Drawing.Color.Wheat;
            this.layeredCheckButton1.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredCheckButton1.Borders.BottomWidth = 1;
            this.layeredCheckButton1.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredCheckButton1.Borders.LeftWidth = 1;
            this.layeredCheckButton1.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredCheckButton1.Borders.RightWidth = 1;
            this.layeredCheckButton1.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredCheckButton1.Borders.TopWidth = 1;
            this.layeredCheckButton1.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredCheckButton1.Canvas")));
            this.layeredCheckButton1.Checked = false;
            this.layeredCheckButton1.CheckedHover = ((System.Drawing.Image)(resources.GetObject("layeredCheckButton1.CheckedHover")));
            this.layeredCheckButton1.CheckedNormal = ((System.Drawing.Image)(resources.GetObject("layeredCheckButton1.CheckedNormal")));
            this.layeredCheckButton1.CheckedPressed = ((System.Drawing.Image)(resources.GetObject("layeredCheckButton1.CheckedPressed")));
            this.layeredCheckButton1.CheckOnClick = false;
            this.layeredCheckButton1.ControlState = LayeredSkin.Controls.ControlStates.Normal;
            this.layeredCheckButton1.HoverImage = ((System.Drawing.Image)(resources.GetObject("layeredCheckButton1.HoverImage")));
            this.layeredCheckButton1.IsPureColor = false;
            this.layeredCheckButton1.Location = new System.Drawing.Point(83, 12);
            this.layeredCheckButton1.Name = "layeredCheckButton1";
            this.layeredCheckButton1.NormalImage = ((System.Drawing.Image)(resources.GetObject("layeredCheckButton1.NormalImage")));
            this.layeredCheckButton1.PressedImage = ((System.Drawing.Image)(resources.GetObject("layeredCheckButton1.PressedImage")));
            this.layeredCheckButton1.Radius = 10;
            this.layeredCheckButton1.ShowBorder = true;
            this.layeredCheckButton1.Size = new System.Drawing.Size(30, 14);
            this.layeredCheckButton1.TabIndex = 21;
            this.layeredCheckButton1.UncheckedHover = ((System.Drawing.Image)(resources.GetObject("layeredCheckButton1.UncheckedHover")));
            this.layeredCheckButton1.UncheckedNormal = ((System.Drawing.Image)(resources.GetObject("layeredCheckButton1.UncheckedNormal")));
            this.layeredCheckButton1.UncheckedPressed = ((System.Drawing.Image)(resources.GetObject("layeredCheckButton1.UncheckedPressed")));
            this.layeredCheckButton1.Click += new System.EventHandler(this.layeredCheckButton1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "Enabel EQ:";
            // 
            // FormEq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 299);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.layeredCheckButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.eq10);
            this.Controls.Add(this.eq9);
            this.Controls.Add(this.eq8);
            this.Controls.Add(this.eq7);
            this.Controls.Add(this.eq6);
            this.Controls.Add(this.eq5);
            this.Controls.Add(this.eq4);
            this.Controls.Add(this.eq3);
            this.Controls.Add(this.eq2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eq1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eq均衡器";
            this.Load += new System.EventHandler(this.FormEq_Load);
            this.Shown += new System.EventHandler(this.FormEq_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.eq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eq9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar eq1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar eq2;
        private System.Windows.Forms.TrackBar eq4;
        private System.Windows.Forms.TrackBar eq3;
        private System.Windows.Forms.TrackBar eq6;
        private System.Windows.Forms.TrackBar eq5;
        private System.Windows.Forms.TrackBar eq8;
        private System.Windows.Forms.TrackBar eq7;
        private System.Windows.Forms.TrackBar eq10;
        private System.Windows.Forms.TrackBar eq9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private LayeredSkin.Controls.LayeredCheckButton layeredCheckButton1;
        private System.Windows.Forms.Label label6;
    }
}