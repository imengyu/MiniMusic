namespace MusicPlayer
{
    partial class FormErrorReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormErrorReport));
            LayeredSkin.DirectUI.DuiTextBox duiTextBox8 = new LayeredSkin.DirectUI.DuiTextBox();
            this.layeredButton1 = new LayeredSkin.Controls.LayeredButton();
            this.button1 = new MusicPlayer.Plugins.Button();
            this.button2 = new MusicPlayer.Plugins.Button();
            this.layeredLabel1 = new LayeredSkin.Controls.LayeredLabel();
            this.layeredLabel2 = new LayeredSkin.Controls.LayeredLabel();
            this.layeredLabel3 = new LayeredSkin.Controls.LayeredLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.layeredBaseControl1 = new LayeredSkin.Controls.LayeredBaseControl();
            this.SuspendLayout();
            // 
            // layeredButton1
            // 
            this.layeredButton1.AdaptImage = true;
            this.layeredButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredButton1.BaseColor = System.Drawing.Color.Wheat;
            this.layeredButton1.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredButton1.Borders.BottomWidth = 1;
            this.layeredButton1.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredButton1.Borders.LeftWidth = 1;
            this.layeredButton1.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredButton1.Borders.RightWidth = 1;
            this.layeredButton1.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredButton1.Borders.TopWidth = 1;
            this.layeredButton1.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredButton1.Canvas")));
            this.layeredButton1.ControlState = LayeredSkin.Controls.ControlStates.Normal;
            this.layeredButton1.HaloColor = System.Drawing.Color.White;
            this.layeredButton1.HaloSize = 5;
            this.layeredButton1.HoverImage = global::MusicPlayer.Properties.Resources.ichrome_tab_close_h;
            this.layeredButton1.IsPureColor = false;
            this.layeredButton1.Location = new System.Drawing.Point(410, 29);
            this.layeredButton1.Name = "layeredButton1";
            this.layeredButton1.NormalImage = global::MusicPlayer.Properties.Resources.ichrome_tab_close_n;
            this.layeredButton1.PressedImage = global::MusicPlayer.Properties.Resources.ichrome_tab_close_p;
            this.layeredButton1.Radius = 10;
            this.layeredButton1.ShowBorder = true;
            this.layeredButton1.Size = new System.Drawing.Size(14, 14);
            this.layeredButton1.TabIndex = 0;
            this.layeredButton1.TextLocationOffset = new System.Drawing.Point(0, 0);
            this.layeredButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.layeredButton1.TextShowMode = LayeredSkin.TextShowModes.Halo;
            this.layeredButton1.Click += new System.EventHandler(this.layeredButton1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.HoverImage = global::MusicPlayer.Properties.Resources.btn_r_01_h;
            this.button1.Location = new System.Drawing.Point(24, 403);
            this.button1.Name = "button1";
            this.button1.NormalImage = global::MusicPlayer.Properties.Resources.btn_r_01_n;
            this.button1.Palace = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button1.PressImage = global::MusicPlayer.Properties.Resources.btn_r_01_p;
            this.button1.Size = new System.Drawing.Size(199, 28);
            this.button1.SizeMode = MusicPlayer.Plugins.Button.ButtonImageMode.Palace;
            this.button1.TabIndex = 1;
            this.button1.Text = "发送错误报告帮助我们解决问题";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.HoverImage = global::MusicPlayer.Properties.Resources.btn_r_01_h;
            this.button2.Location = new System.Drawing.Point(324, 403);
            this.button2.Name = "button2";
            this.button2.NormalImage = global::MusicPlayer.Properties.Resources.btn_r_01_n;
            this.button2.Palace = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button2.PressImage = global::MusicPlayer.Properties.Resources.btn_r_01_p;
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.SizeMode = MusicPlayer.Plugins.Button.ButtonImageMode.Palace;
            this.button2.TabIndex = 2;
            this.button2.Text = "不发送并关闭";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // layeredLabel1
            // 
            this.layeredLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredLabel1.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredLabel1.Borders.BottomWidth = 1;
            this.layeredLabel1.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredLabel1.Borders.LeftWidth = 1;
            this.layeredLabel1.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredLabel1.Borders.RightWidth = 1;
            this.layeredLabel1.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredLabel1.Borders.TopWidth = 1;
            this.layeredLabel1.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredLabel1.Canvas")));
            this.layeredLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.layeredLabel1.HaloSize = 5;
            this.layeredLabel1.Location = new System.Drawing.Point(85, 31);
            this.layeredLabel1.Name = "layeredLabel1";
            this.layeredLabel1.Size = new System.Drawing.Size(308, 26);
            this.layeredLabel1.TabIndex = 3;
            this.layeredLabel1.Text = "很抱歉.迷你音乐刚才遇到了一个错误.";
            this.layeredLabel1.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            // 
            // layeredLabel2
            // 
            this.layeredLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredLabel2.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredLabel2.Borders.BottomWidth = 1;
            this.layeredLabel2.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredLabel2.Borders.LeftWidth = 1;
            this.layeredLabel2.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredLabel2.Borders.RightWidth = 1;
            this.layeredLabel2.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredLabel2.Borders.TopWidth = 1;
            this.layeredLabel2.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredLabel2.Canvas")));
            this.layeredLabel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.layeredLabel2.HaloSize = 5;
            this.layeredLabel2.Location = new System.Drawing.Point(87, 55);
            this.layeredLabel2.Name = "layeredLabel2";
            this.layeredLabel2.Size = new System.Drawing.Size(337, 55);
            this.layeredLabel2.TabIndex = 4;
            this.layeredLabel2.Text = "这非常有可能是我们的软件存在Bug,我们在错误发生时生成了一份错误报告,其中不包含您的任何信息.请您把这份报告发送给我们,帮助我们解决改问题,谢谢!";
            this.layeredLabel2.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            // 
            // layeredLabel3
            // 
            this.layeredLabel3.AutoSize = true;
            this.layeredLabel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredLabel3.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredLabel3.Borders.BottomWidth = 1;
            this.layeredLabel3.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredLabel3.Borders.LeftWidth = 1;
            this.layeredLabel3.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredLabel3.Borders.RightWidth = 1;
            this.layeredLabel3.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredLabel3.Borders.TopWidth = 1;
            this.layeredLabel3.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredLabel3.Canvas")));
            this.layeredLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.layeredLabel3.HaloSize = 5;
            this.layeredLabel3.Location = new System.Drawing.Point(12, 117);
            this.layeredLabel3.Name = "layeredLabel3";
            this.layeredLabel3.Size = new System.Drawing.Size(211, 22);
            this.layeredLabel3.TabIndex = 5;
            this.layeredLabel3.Text = "   以下是该报告的详细内容:";
            this.layeredLabel3.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabel1.Location = new System.Drawing.Point(200, 380);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(224, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "如果您想了解更多错误信息，请点击这里";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // layeredBaseControl1
            // 
            this.layeredBaseControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredBaseControl1.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredBaseControl1.Borders.BottomWidth = 1;
            this.layeredBaseControl1.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredBaseControl1.Borders.LeftWidth = 1;
            this.layeredBaseControl1.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredBaseControl1.Borders.RightWidth = 1;
            this.layeredBaseControl1.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredBaseControl1.Borders.TopWidth = 1;
            this.layeredBaseControl1.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredBaseControl1.Canvas")));
            duiTextBox8.AutoHeight = false;
            duiTextBox8.AutoSize = false;
            duiTextBox8.BackColor = System.Drawing.Color.Transparent;
            duiTextBox8.BackgroundImage = null;
            duiTextBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            duiTextBox8.BackgroundRender = null;
            duiTextBox8.BitmapCache = false;
            duiTextBox8.BorderPath = null;
            duiTextBox8.BorderRender = null;
            duiTextBox8.Borders.BottomColor = System.Drawing.Color.Empty;
            duiTextBox8.Borders.BottomWidth = 1;
            duiTextBox8.Borders.LeftColor = System.Drawing.Color.Empty;
            duiTextBox8.Borders.LeftWidth = 1;
            duiTextBox8.Borders.RightColor = System.Drawing.Color.Empty;
            duiTextBox8.Borders.RightWidth = 1;
            duiTextBox8.Borders.TopColor = System.Drawing.Color.Empty;
            duiTextBox8.Borders.TopWidth = 1;
            duiTextBox8.CanFocus = true;
            duiTextBox8.CaretColor = System.Drawing.SystemColors.ControlText;
            duiTextBox8.CaretIndex = 0;
            duiTextBox8.ClientRectangle = new System.Drawing.Rectangle(0, 0, 397, 232);
            duiTextBox8.CurrentCursor = System.Windows.Forms.Cursors.Default;
            duiTextBox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            duiTextBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            duiTextBox8.Enabled = true;
            duiTextBox8.Font = new System.Drawing.Font("微软雅黑", 9F);
            duiTextBox8.ForeColor = System.Drawing.SystemColors.ControlText;
            duiTextBox8.Height = 232;
            duiTextBox8.IsInsert = true;
            duiTextBox8.IsMoveParentPaint = true;
            duiTextBox8.Left = 0;
            duiTextBox8.Location = new System.Drawing.Point(0, 0);
            duiTextBox8.Margin = new System.Windows.Forms.Padding(0);
            duiTextBox8.Multiline = true;
            duiTextBox8.Name = "tb_error";
            duiTextBox8.ParentInvalidate = true;
            duiTextBox8.ReadOnly = false;
            duiTextBox8.RollSize = 20;
            duiTextBox8.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            duiTextBox8.ScrollBarHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            duiTextBox8.ScrollBarNormalColor = System.Drawing.Color.Gray;
            duiTextBox8.ScrollBarPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            duiTextBox8.SelectionBackColor = System.Drawing.Color.Gray;
            duiTextBox8.SelectionColor = System.Drawing.Color.White;
            duiTextBox8.SelectionLength = 0;
            duiTextBox8.SelectionStart = 0;
            duiTextBox8.ShowBorder = true;
            duiTextBox8.ShowScrollBar = true;
            duiTextBox8.Size = new System.Drawing.Size(397, 232);
            duiTextBox8.SuspendInvalidate = false;
            duiTextBox8.Tag = null;
            duiTextBox8.Text = "123Abc测试啊额果然饿的个啊豆腐干";
            duiTextBox8.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            duiTextBox8.Top = 0;
            duiTextBox8.Visible = true;
            duiTextBox8.Width = 397;
            this.layeredBaseControl1.DUIControls.AddRange(new LayeredSkin.DirectUI.DuiBaseControl[] {
            duiTextBox8});
            this.layeredBaseControl1.Location = new System.Drawing.Point(27, 145);
            this.layeredBaseControl1.Name = "layeredBaseControl1";
            this.layeredBaseControl1.Size = new System.Drawing.Size(397, 232);
            this.layeredBaseControl1.TabIndex = 7;
            this.layeredBaseControl1.Text = "layeredBaseControl1";
            // 
            // FormErrorReport
            // 
            this.AnimationType = LayeredSkin.Forms.AnimationTypes.Custom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CaptionShowMode = LayeredSkin.TextShowModes.None;
            this.ClientSize = new System.Drawing.Size(454, 459);
            this.Controls.Add(this.layeredBaseControl1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.layeredLabel3);
            this.Controls.Add(this.layeredLabel2);
            this.Controls.Add(this.layeredLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.layeredButton1);
            this.DrawIcon = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormErrorReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "迷你音乐错误报告";
            this.Load += new System.EventHandler(this.FormErrorReport_Load);
            this.Shown += new System.EventHandler(this.FormErrorReport_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LayeredSkin.Controls.LayeredButton layeredButton1;
        private Plugins.Button button1;
        private Plugins.Button button2;
        private LayeredSkin.Controls.LayeredLabel layeredLabel1;
        private LayeredSkin.Controls.LayeredLabel layeredLabel2;
        private LayeredSkin.Controls.LayeredLabel layeredLabel3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private LayeredSkin.Controls.LayeredBaseControl layeredBaseControl1;
    }
}