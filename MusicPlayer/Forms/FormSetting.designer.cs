namespace MusicPlayer
{
    partial class FormSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
            this.layeredTabControl1 = new LayeredSkin.Controls.LayeredTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.qqCheckBox5 = new ControlExs.QQCheckBox();
            this.qqCheckBox4 = new ControlExs.QQCheckBox();
            this.layeredLabel12 = new LayeredSkin.Controls.LayeredLabel();
            this.layeredLabel11 = new LayeredSkin.Controls.LayeredLabel();
            this.qqRadioButton2 = new ControlExs.QQRadioButton();
            this.qqRadioButton1 = new ControlExs.QQRadioButton();
            this.layeredLabel10 = new LayeredSkin.Controls.LayeredLabel();
            this.qqCheckBox2 = new ControlExs.QQCheckBox();
            this.layeredLabel8 = new LayeredSkin.Controls.LayeredLabel();
            this.layeredLabel9 = new LayeredSkin.Controls.LayeredLabel();
            this.button2 = new MusicPlayer.Plugins.Button();
            this.button3 = new MusicPlayer.Plugins.Button();
            this.layeredTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layeredTabControl1
            // 
            this.layeredTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.layeredTabControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredTabControl1.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredTabControl1.Borders.BottomWidth = 1;
            this.layeredTabControl1.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredTabControl1.Borders.LeftWidth = 1;
            this.layeredTabControl1.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredTabControl1.Borders.RightWidth = 1;
            this.layeredTabControl1.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredTabControl1.Borders.TopWidth = 1;
            this.layeredTabControl1.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredTabControl1.Canvas")));
            this.layeredTabControl1.Controls.Add(this.tabPage1);
            this.layeredTabControl1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.layeredTabControl1.HoverBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.layeredTabControl1.ItemBackgroundImage = null;
            this.layeredTabControl1.ItemBackgroundImageHover = null;
            this.layeredTabControl1.ItemBackgroundImageSelected = null;
            this.layeredTabControl1.ItemSize = new System.Drawing.Size(22, 100);
            this.layeredTabControl1.Location = new System.Drawing.Point(12, 52);
            this.layeredTabControl1.Multiline = true;
            this.layeredTabControl1.Name = "layeredTabControl1";
            this.layeredTabControl1.NormalBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.White};
            this.layeredTabControl1.SelectedBackColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(2)))), ((int)(((byte)(155)))), ((int)(((byte)(235)))))};
            this.layeredTabControl1.SelectedIndex = 0;
            this.layeredTabControl1.Size = new System.Drawing.Size(542, 329);
            this.layeredTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.layeredTabControl1.TabIndex = 1;
            this.layeredTabControl1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkLabel3);
            this.tabPage1.Controls.Add(this.linkLabel2);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.qqCheckBox5);
            this.tabPage1.Controls.Add(this.qqCheckBox4);
            this.tabPage1.Controls.Add(this.layeredLabel12);
            this.tabPage1.Controls.Add(this.layeredLabel11);
            this.tabPage1.Controls.Add(this.qqRadioButton2);
            this.tabPage1.Controls.Add(this.qqRadioButton1);
            this.tabPage1.Controls.Add(this.layeredLabel10);
            this.tabPage1.Controls.Add(this.qqCheckBox2);
            this.tabPage1.Controls.Add(this.layeredLabel8);
            this.tabPage1.Controls.Add(this.layeredLabel9);
            this.tabPage1.Location = new System.Drawing.Point(100, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(442, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel3.Location = new System.Drawing.Point(51, 294);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(366, 17);
            this.linkLabel3.TabIndex = 20;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "把迷你音乐作为默认音乐播放器（Win10需要在\"设置\"中手动设置）";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel2.Location = new System.Drawing.Point(51, 205);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(68, 17);
            this.linkLabel2.TabIndex = 18;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "打开均衡器";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel1.Location = new System.Drawing.Point(51, 248);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 17);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "高级设置";
            // 
            // qqCheckBox5
            // 
            this.qqCheckBox5.AutoSize = true;
            this.qqCheckBox5.BackColor = System.Drawing.Color.Transparent;
            this.qqCheckBox5.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.qqCheckBox5.Location = new System.Drawing.Point(33, 224);
            this.qqCheckBox5.Name = "qqCheckBox5";
            this.qqCheckBox5.Size = new System.Drawing.Size(147, 21);
            this.qqCheckBox5.TabIndex = 16;
            this.qqCheckBox5.Text = "激活声音淡出淡入功能";
            this.qqCheckBox5.UseVisualStyleBackColor = false;
            // 
            // qqCheckBox4
            // 
            this.qqCheckBox4.AutoSize = true;
            this.qqCheckBox4.BackColor = System.Drawing.Color.Transparent;
            this.qqCheckBox4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.qqCheckBox4.Location = new System.Drawing.Point(33, 181);
            this.qqCheckBox4.Name = "qqCheckBox4";
            this.qqCheckBox4.Size = new System.Drawing.Size(104, 21);
            this.qqCheckBox4.TabIndex = 15;
            this.qqCheckBox4.Text = "启用EQ均衡器";
            this.qqCheckBox4.UseVisualStyleBackColor = false;
            // 
            // layeredLabel12
            // 
            this.layeredLabel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredLabel12.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredLabel12.Borders.BottomWidth = 1;
            this.layeredLabel12.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredLabel12.Borders.LeftWidth = 1;
            this.layeredLabel12.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredLabel12.Borders.RightWidth = 1;
            this.layeredLabel12.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredLabel12.Borders.TopWidth = 1;
            this.layeredLabel12.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredLabel12.Canvas")));
            this.layeredLabel12.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.layeredLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.layeredLabel12.HaloSize = 5;
            this.layeredLabel12.Location = new System.Drawing.Point(33, 272);
            this.layeredLabel12.Name = "layeredLabel12";
            this.layeredLabel12.Size = new System.Drawing.Size(99, 19);
            this.layeredLabel12.TabIndex = 13;
            this.layeredLabel12.Text = "文件关联：";
            this.layeredLabel12.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.layeredLabel12.TextShowMode = LayeredSkin.TextShowModes.Ordinary;
            // 
            // layeredLabel11
            // 
            this.layeredLabel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredLabel11.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredLabel11.Borders.BottomWidth = 1;
            this.layeredLabel11.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredLabel11.Borders.LeftWidth = 1;
            this.layeredLabel11.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredLabel11.Borders.RightWidth = 1;
            this.layeredLabel11.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredLabel11.Borders.TopWidth = 1;
            this.layeredLabel11.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredLabel11.Canvas")));
            this.layeredLabel11.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.layeredLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.layeredLabel11.HaloSize = 5;
            this.layeredLabel11.Location = new System.Drawing.Point(33, 159);
            this.layeredLabel11.Name = "layeredLabel11";
            this.layeredLabel11.Size = new System.Drawing.Size(99, 19);
            this.layeredLabel11.TabIndex = 12;
            this.layeredLabel11.Text = "其他设置：";
            this.layeredLabel11.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.layeredLabel11.TextShowMode = LayeredSkin.TextShowModes.Ordinary;
            // 
            // qqRadioButton2
            // 
            this.qqRadioButton2.AutoSize = true;
            this.qqRadioButton2.BackColor = System.Drawing.Color.Transparent;
            this.qqRadioButton2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.qqRadioButton2.Location = new System.Drawing.Point(33, 133);
            this.qqRadioButton2.Name = "qqRadioButton2";
            this.qqRadioButton2.Size = new System.Drawing.Size(122, 21);
            this.qqRadioButton2.TabIndex = 11;
            this.qqRadioButton2.TabStop = true;
            this.qqRadioButton2.Text = "最小化到托盘图标";
            this.qqRadioButton2.UseVisualStyleBackColor = false;
            // 
            // qqRadioButton1
            // 
            this.qqRadioButton1.AutoSize = true;
            this.qqRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.qqRadioButton1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.qqRadioButton1.Location = new System.Drawing.Point(33, 112);
            this.qqRadioButton1.Name = "qqRadioButton1";
            this.qqRadioButton1.Size = new System.Drawing.Size(74, 21);
            this.qqRadioButton1.TabIndex = 10;
            this.qqRadioButton1.TabStop = true;
            this.qqRadioButton1.Text = "退出程序";
            this.qqRadioButton1.UseVisualStyleBackColor = false;
            // 
            // layeredLabel10
            // 
            this.layeredLabel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredLabel10.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredLabel10.Borders.BottomWidth = 1;
            this.layeredLabel10.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredLabel10.Borders.LeftWidth = 1;
            this.layeredLabel10.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredLabel10.Borders.RightWidth = 1;
            this.layeredLabel10.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredLabel10.Borders.TopWidth = 1;
            this.layeredLabel10.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredLabel10.Canvas")));
            this.layeredLabel10.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.layeredLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.layeredLabel10.HaloSize = 5;
            this.layeredLabel10.Location = new System.Drawing.Point(33, 88);
            this.layeredLabel10.Name = "layeredLabel10";
            this.layeredLabel10.Size = new System.Drawing.Size(99, 19);
            this.layeredLabel10.TabIndex = 9;
            this.layeredLabel10.Text = "关闭主窗体时：";
            this.layeredLabel10.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.layeredLabel10.TextShowMode = LayeredSkin.TextShowModes.Ordinary;
            // 
            // qqCheckBox2
            // 
            this.qqCheckBox2.AutoSize = true;
            this.qqCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.qqCheckBox2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.qqCheckBox2.Location = new System.Drawing.Point(33, 61);
            this.qqCheckBox2.Name = "qqCheckBox2";
            this.qqCheckBox2.Size = new System.Drawing.Size(99, 21);
            this.qqCheckBox2.TabIndex = 8;
            this.qqCheckBox2.Text = "自动播放歌曲";
            this.qqCheckBox2.UseVisualStyleBackColor = false;
            this.qqCheckBox2.CheckedChanged += new System.EventHandler(this.qqCheckBox2_CheckedChanged);
            // 
            // layeredLabel8
            // 
            this.layeredLabel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredLabel8.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredLabel8.Borders.BottomWidth = 1;
            this.layeredLabel8.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredLabel8.Borders.LeftWidth = 1;
            this.layeredLabel8.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredLabel8.Borders.RightWidth = 1;
            this.layeredLabel8.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredLabel8.Borders.TopWidth = 1;
            this.layeredLabel8.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredLabel8.Canvas")));
            this.layeredLabel8.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.layeredLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.layeredLabel8.HaloSize = 5;
            this.layeredLabel8.Location = new System.Drawing.Point(33, 36);
            this.layeredLabel8.Name = "layeredLabel8";
            this.layeredLabel8.Size = new System.Drawing.Size(75, 19);
            this.layeredLabel8.TabIndex = 7;
            this.layeredLabel8.Text = "启动时：";
            this.layeredLabel8.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.layeredLabel8.TextShowMode = LayeredSkin.TextShowModes.Ordinary;
            // 
            // layeredLabel9
            // 
            this.layeredLabel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredLabel9.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredLabel9.Borders.BottomWidth = 1;
            this.layeredLabel9.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredLabel9.Borders.LeftWidth = 1;
            this.layeredLabel9.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredLabel9.Borders.RightWidth = 1;
            this.layeredLabel9.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredLabel9.Borders.TopWidth = 1;
            this.layeredLabel9.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredLabel9.Canvas")));
            this.layeredLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.layeredLabel9.HaloSize = 5;
            this.layeredLabel9.Location = new System.Drawing.Point(33, 15);
            this.layeredLabel9.Name = "layeredLabel9";
            this.layeredLabel9.Size = new System.Drawing.Size(137, 21);
            this.layeredLabel9.TabIndex = 6;
            this.layeredLabel9.Text = "常规设置";
            this.layeredLabel9.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.layeredLabel9.TextShowMode = LayeredSkin.TextShowModes.Ordinary;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.HoverImage = global::MusicPlayer.Properties.Resources.button_white_hover;
            this.button2.Location = new System.Drawing.Point(450, 389);
            this.button2.Name = "button2";
            this.button2.NormalImage = global::MusicPlayer.Properties.Resources.button_white_normal;
            this.button2.Palace = new System.Windows.Forms.Padding(5);
            this.button2.PressImage = global::MusicPlayer.Properties.Resources.button_white_click;
            this.button2.Size = new System.Drawing.Size(104, 27);
            this.button2.SizeMode = MusicPlayer.Plugins.Button.ButtonImageMode.Palace;
            this.button2.TabIndex = 3;
            this.button2.Text = "保存并关闭";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.HoverImage = global::MusicPlayer.Properties.Resources.button_white_hover;
            this.button3.Location = new System.Drawing.Point(370, 389);
            this.button3.Name = "button3";
            this.button3.NormalImage = global::MusicPlayer.Properties.Resources.button_white_normal;
            this.button3.Palace = new System.Windows.Forms.Padding(5);
            this.button3.PressImage = global::MusicPlayer.Properties.Resources.button_white_click;
            this.button3.Size = new System.Drawing.Size(74, 27);
            this.button3.SizeMode = MusicPlayer.Plugins.Button.ButtonImageMode.Palace;
            this.button3.TabIndex = 4;
            this.button3.Text = "取消";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 426);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.layeredTabControl1);
            this.EnableMiniButton = false;
            this.Name = "FormSetting";
            this.ShowInTaskbar = false;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.Shown += new System.EventHandler(this.FormSetting_Shown);
            this.Controls.SetChildIndex(this.layeredTabControl1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.layeredTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LayeredSkin.Controls.LayeredTabControl layeredTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Plugins.Button button2;
        private Plugins.Button button3;
        private LayeredSkin.Controls.LayeredLabel layeredLabel12;
        private LayeredSkin.Controls.LayeredLabel layeredLabel11;
        private ControlExs.QQRadioButton qqRadioButton2;
        private ControlExs.QQRadioButton qqRadioButton1;
        private LayeredSkin.Controls.LayeredLabel layeredLabel10;
        private ControlExs.QQCheckBox qqCheckBox2;
        private LayeredSkin.Controls.LayeredLabel layeredLabel8;
        private LayeredSkin.Controls.LayeredLabel layeredLabel9;
        private ControlExs.QQCheckBox qqCheckBox5;
        private ControlExs.QQCheckBox qqCheckBox4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}