namespace MusicPlayer
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btn_soundsch = new LayeredSkin.Controls.LayeredCheckButton();
            this.pl_bg = new LayeredSkin.Controls.LayeredPanel();
            this.pl_tip_container = new LayeredSkin.Controls.LayeredBaseControl();
            this.pb_drawbar = new LayeredSkin.Controls.LayeredPictureBox();
            this.pl_playmodbg = new LayeredSkin.Controls.LayeredBaseControl();
            this.pb_intro = new LayeredSkin.Controls.LayeredPictureBox();
            this.musicList1 = new MusicPlayer.MyLayeredSkin.MusicList();
            this.tkb_basic = new LayeredSkin.Controls.LayeredTrackBar();
            this.pl_sound = new LayeredSkin.Controls.LayeredPanel();
            this.tkb_sound = new LayeredSkin.Controls.LayeredTrackBar();
            this.scorllbar = new LayeredSkin.Controls.LayeredBaseControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.autoDocker1 = new MusicPlayer.AutoDocker(this.components);
            this.pl_bg.SuspendLayout();
            this.pl_sound.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_soundsch
            // 
            this.btn_soundsch.AdaptImage = true;
            this.btn_soundsch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_soundsch.BaseColor = System.Drawing.Color.Wheat;
            this.btn_soundsch.Borders.BottomColor = System.Drawing.Color.Empty;
            this.btn_soundsch.Borders.BottomWidth = 1;
            this.btn_soundsch.Borders.LeftColor = System.Drawing.Color.Empty;
            this.btn_soundsch.Borders.LeftWidth = 1;
            this.btn_soundsch.Borders.RightColor = System.Drawing.Color.Empty;
            this.btn_soundsch.Borders.RightWidth = 1;
            this.btn_soundsch.Borders.TopColor = System.Drawing.Color.Empty;
            this.btn_soundsch.Borders.TopWidth = 1;
            this.btn_soundsch.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("btn_soundsch.Canvas")));
            this.btn_soundsch.Checked = false;
            this.btn_soundsch.CheckedHover = ((System.Drawing.Image)(resources.GetObject("btn_soundsch.CheckedHover")));
            this.btn_soundsch.CheckedNormal = ((System.Drawing.Image)(resources.GetObject("btn_soundsch.CheckedNormal")));
            this.btn_soundsch.CheckedPressed = ((System.Drawing.Image)(resources.GetObject("btn_soundsch.CheckedPressed")));
            this.btn_soundsch.CheckOnClick = false;
            this.btn_soundsch.ControlState = LayeredSkin.Controls.ControlStates.Normal;
            this.btn_soundsch.HoverImage = ((System.Drawing.Image)(resources.GetObject("btn_soundsch.HoverImage")));
            this.btn_soundsch.IsPureColor = false;
            this.btn_soundsch.Location = new System.Drawing.Point(116, 17);
            this.btn_soundsch.Name = "btn_soundsch";
            this.btn_soundsch.NormalImage = ((System.Drawing.Image)(resources.GetObject("btn_soundsch.NormalImage")));
            this.btn_soundsch.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_soundsch.PressedImage")));
            this.btn_soundsch.Radius = 10;
            this.btn_soundsch.ShowBorder = true;
            this.btn_soundsch.Size = new System.Drawing.Size(28, 26);
            this.btn_soundsch.TabIndex = 39;
            this.toolTip1.SetToolTip(this.btn_soundsch, "静音");
            this.btn_soundsch.UncheckedHover = ((System.Drawing.Image)(resources.GetObject("btn_soundsch.UncheckedHover")));
            this.btn_soundsch.UncheckedNormal = ((System.Drawing.Image)(resources.GetObject("btn_soundsch.UncheckedNormal")));
            this.btn_soundsch.UncheckedPressed = ((System.Drawing.Image)(resources.GetObject("btn_soundsch.UncheckedPressed")));
            this.btn_soundsch.Click += new System.EventHandler(this.btn_soundsch_Click);
            this.btn_soundsch.MouseEnter += new System.EventHandler(this.btn_soundsch_MouseEnter);
            // 
            // pl_bg
            // 
            this.pl_bg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pl_bg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pl_bg.Borders.BottomColor = System.Drawing.Color.Empty;
            this.pl_bg.Borders.BottomWidth = 1;
            this.pl_bg.Borders.LeftColor = System.Drawing.Color.Empty;
            this.pl_bg.Borders.LeftWidth = 1;
            this.pl_bg.Borders.RightColor = System.Drawing.Color.Empty;
            this.pl_bg.Borders.RightWidth = 1;
            this.pl_bg.Borders.TopColor = System.Drawing.Color.Empty;
            this.pl_bg.Borders.TopWidth = 1;
            this.pl_bg.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("pl_bg.Canvas")));
            this.pl_bg.Controls.Add(this.pl_tip_container);
            this.pl_bg.Controls.Add(this.pb_drawbar);
            this.pl_bg.Controls.Add(this.pl_playmodbg);
            this.pl_bg.Controls.Add(this.pb_intro);
            this.pl_bg.Controls.Add(this.musicList1);
            this.pl_bg.Controls.Add(this.tkb_basic);
            this.pl_bg.Controls.Add(this.btn_soundsch);
            this.pl_bg.Controls.Add(this.pl_sound);
            this.pl_bg.Controls.Add(this.scorllbar);
            this.pl_bg.Location = new System.Drawing.Point(0, 0);
            this.pl_bg.Name = "pl_bg";
            this.pl_bg.Size = new System.Drawing.Size(415, 505);
            this.pl_bg.TabIndex = 40;
            this.pl_bg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_bg_MouseDown);
            this.pl_bg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pl_bg_MouseMove);
            this.pl_bg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pl_bg_MouseUp);
            // 
            // pl_tip_container
            // 
            this.pl_tip_container.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_tip_container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pl_tip_container.Borders.BottomColor = System.Drawing.Color.Empty;
            this.pl_tip_container.Borders.BottomWidth = 1;
            this.pl_tip_container.Borders.LeftColor = System.Drawing.Color.Empty;
            this.pl_tip_container.Borders.LeftWidth = 1;
            this.pl_tip_container.Borders.RightColor = System.Drawing.Color.Empty;
            this.pl_tip_container.Borders.RightWidth = 1;
            this.pl_tip_container.Borders.TopColor = System.Drawing.Color.Empty;
            this.pl_tip_container.Borders.TopWidth = 1;
            this.pl_tip_container.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("pl_tip_container.Canvas")));
            this.pl_tip_container.Location = new System.Drawing.Point(0, 442);
            this.pl_tip_container.Name = "pl_tip_container";
            this.pl_tip_container.Size = new System.Drawing.Size(415, 63);
            this.pl_tip_container.TabIndex = 48;
            this.pl_tip_container.Visible = false;
            this.pl_tip_container.MouseEnter += new System.EventHandler(this.pl_tip_container_MouseEnter);
            this.pl_tip_container.MouseLeave += new System.EventHandler(this.pl_tip_container_MouseLeave);
            // 
            // pb_drawbar
            // 
            this.pb_drawbar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pb_drawbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_drawbar.Borders.BottomColor = System.Drawing.Color.Empty;
            this.pb_drawbar.Borders.BottomWidth = 1;
            this.pb_drawbar.Borders.LeftColor = System.Drawing.Color.Empty;
            this.pb_drawbar.Borders.LeftWidth = 1;
            this.pb_drawbar.Borders.RightColor = System.Drawing.Color.Empty;
            this.pb_drawbar.Borders.RightWidth = 1;
            this.pb_drawbar.Borders.TopColor = System.Drawing.Color.Empty;
            this.pb_drawbar.Borders.TopWidth = 1;
            this.pb_drawbar.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("pb_drawbar.Canvas")));
            this.pb_drawbar.Image = null;
            this.pb_drawbar.Images = null;
            this.pb_drawbar.Interval = 100;
            this.pb_drawbar.Location = new System.Drawing.Point(2, 503);
            this.pb_drawbar.MultiImageAnimation = false;
            this.pb_drawbar.Name = "pb_drawbar";
            this.pb_drawbar.Size = new System.Drawing.Size(412, 1);
            this.pb_drawbar.TabIndex = 47;
            this.pb_drawbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_drawbar_MouseDown);
            this.pb_drawbar.MouseEnter += new System.EventHandler(this.pb_drawbar_MouseEnter);
            this.pb_drawbar.MouseLeave += new System.EventHandler(this.pb_drawbar_MouseLeave);
            this.pb_drawbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_drawbar_MouseMove);
            this.pb_drawbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_drawbar_MouseUp);
            // 
            // pl_playmodbg
            // 
            this.pl_playmodbg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pl_playmodbg.BackgroundImage")));
            this.pl_playmodbg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pl_playmodbg.Borders.BottomColor = System.Drawing.Color.Empty;
            this.pl_playmodbg.Borders.BottomWidth = 1;
            this.pl_playmodbg.Borders.LeftColor = System.Drawing.Color.Empty;
            this.pl_playmodbg.Borders.LeftWidth = 1;
            this.pl_playmodbg.Borders.RightColor = System.Drawing.Color.Empty;
            this.pl_playmodbg.Borders.RightWidth = 1;
            this.pl_playmodbg.Borders.TopColor = System.Drawing.Color.Empty;
            this.pl_playmodbg.Borders.TopWidth = 1;
            this.pl_playmodbg.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("pl_playmodbg.Canvas")));
            this.pl_playmodbg.Location = new System.Drawing.Point(118, 40);
            this.pl_playmodbg.Name = "pl_playmodbg";
            this.pl_playmodbg.Size = new System.Drawing.Size(137, 206);
            this.pl_playmodbg.TabIndex = 45;
            this.pl_playmodbg.Visible = false;
            // 
            // pb_intro
            // 
            this.pb_intro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_intro.BackgroundImage = global::MusicPlayer.Properties.Resources.musicintroc;
            this.pb_intro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_intro.Borders.BottomColor = System.Drawing.Color.Empty;
            this.pb_intro.Borders.BottomWidth = 1;
            this.pb_intro.Borders.LeftColor = System.Drawing.Color.Empty;
            this.pb_intro.Borders.LeftWidth = 1;
            this.pb_intro.Borders.RightColor = System.Drawing.Color.Empty;
            this.pb_intro.Borders.RightWidth = 1;
            this.pb_intro.Borders.TopColor = System.Drawing.Color.Empty;
            this.pb_intro.Borders.TopWidth = 1;
            this.pb_intro.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("pb_intro.Canvas")));
            this.pb_intro.Image = null;
            this.pb_intro.Images = null;
            this.pb_intro.Interval = 100;
            this.pb_intro.Location = new System.Drawing.Point(0, 1);
            this.pb_intro.MultiImageAnimation = false;
            this.pb_intro.Name = "pb_intro";
            this.pb_intro.Size = new System.Drawing.Size(415, 504);
            this.pb_intro.TabIndex = 44;
            // 
            // musicList1
            // 
            this.musicList1.AllowDrop = true;
            this.musicList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musicList1.AutoFocus = false;
            this.musicList1.BackColor = System.Drawing.Color.Transparent;
            this.musicList1.Borders.BottomColor = System.Drawing.Color.Empty;
            this.musicList1.Borders.BottomWidth = 1;
            this.musicList1.Borders.LeftColor = System.Drawing.Color.Empty;
            this.musicList1.Borders.LeftWidth = 1;
            this.musicList1.Borders.RightColor = System.Drawing.Color.Empty;
            this.musicList1.Borders.RightWidth = 1;
            this.musicList1.Borders.TopColor = System.Drawing.Color.Empty;
            this.musicList1.Borders.TopWidth = 1;
            this.musicList1.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("musicList1.Canvas")));
            this.musicList1.EnabledMouseWheel = true;
            this.musicList1.ItemSize = new System.Drawing.Size(100, 100);
            this.musicList1.ListTop = 0;
            this.musicList1.Location = new System.Drawing.Point(0, 104);
            this.musicList1.Name = "musicList1";
            this.musicList1.Orientation = LayeredSkin.Controls.ListOrientation.Vertical;
            this.musicList1.RollSize = 20;
            this.musicList1.ScrollBarBackColor = System.Drawing.Color.Transparent;
            this.musicList1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.musicList1.ScrollBarHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.musicList1.ScrollBarWidth = 5;
            this.musicList1.ShowScrollBar = false;
            this.musicList1.Size = new System.Drawing.Size(415, 375);
            this.musicList1.SmoothScroll = false;
            this.musicList1.TabIndex = 43;
            this.musicList1.Text = "list_main";
            this.musicList1.Ulmul = false;
            this.musicList1.Value = 0D;
            this.musicList1.PlayMusic += new MusicPlayer.MyLayeredSkin.MusicList.MusicControlEventHandle(this.musicList1_PlayMusic);
            this.musicList1.PauseMusic += new System.EventHandler(this.musicList1_PauseMusic);
            this.musicList1.StopMusic += new System.EventHandler(this.musicList1_StopMusic);
            this.musicList1.RefreshListed += new System.EventHandler(this.musicList1_RefreshListed);
            this.musicList1.ItemRightCilcked += new MusicPlayer.MyLayeredSkin.MusicList.MusicControlClickEventHandle(this.musicList1_ItemRightCilcked);
            this.musicList1.ListMenuCilcked += new MusicPlayer.MyLayeredSkin.MusicList.MusicControlClickEventHandle(this.musicList1_ListMenuCilcked);
            this.musicList1.ValueChanged += new System.EventHandler(this.musicList1_ValueChanged);
            this.musicList1.DragDrop += new System.Windows.Forms.DragEventHandler(this.musicList1_DragDrop);
            this.musicList1.DragEnter += new System.Windows.Forms.DragEventHandler(this.musicList1_DragEnter);
            this.musicList1.MouseEnter += new System.EventHandler(this.musicList1_MouseEnter);
            // 
            // tkb_basic
            // 
            this.tkb_basic.AdaptImage = true;
            this.tkb_basic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tkb_basic.BackImage = null;
            this.tkb_basic.BackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tkb_basic.Borders.BottomColor = System.Drawing.Color.Empty;
            this.tkb_basic.Borders.BottomWidth = 1;
            this.tkb_basic.Borders.LeftColor = System.Drawing.Color.Empty;
            this.tkb_basic.Borders.LeftWidth = 1;
            this.tkb_basic.Borders.RightColor = System.Drawing.Color.Empty;
            this.tkb_basic.Borders.RightWidth = 1;
            this.tkb_basic.Borders.TopColor = System.Drawing.Color.Empty;
            this.tkb_basic.Borders.TopWidth = 1;
            this.tkb_basic.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("tkb_basic.Canvas")));
            this.tkb_basic.ControlRectangle = new System.Drawing.Rectangle(5, 5, 383, 15);
            this.tkb_basic.LineWidth = 3;
            this.tkb_basic.Location = new System.Drawing.Point(12, 76);
            this.tkb_basic.MouseCanControl = true;
            this.tkb_basic.Name = "tkb_basic";
            this.tkb_basic.Orientation = LayeredSkin.Controls.Orientations.Horizontal;
            this.tkb_basic.PointImage = ((System.Drawing.Image)(resources.GetObject("tkb_basic.PointImage")));
            this.tkb_basic.PointImageHover = ((System.Drawing.Image)(resources.GetObject("tkb_basic.PointImageHover")));
            this.tkb_basic.PointImagePressed = ((System.Drawing.Image)(resources.GetObject("tkb_basic.PointImagePressed")));
            this.tkb_basic.PointState = LayeredSkin.Controls.ControlStates.Normal;
            this.tkb_basic.Size = new System.Drawing.Size(393, 25);
            this.tkb_basic.SurfaceImage = null;
            this.tkb_basic.SurfaceLineColor = System.Drawing.Color.White;
            this.tkb_basic.TabIndex = 42;
            this.tkb_basic.Value = 0D;
            this.tkb_basic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tkb_basic_MouseDown);
            this.tkb_basic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tkb_basic_MouseUp);
            // 
            // pl_sound
            // 
            this.pl_sound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pl_sound.BackgroundImage")));
            this.pl_sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pl_sound.Borders.BottomColor = System.Drawing.Color.Empty;
            this.pl_sound.Borders.BottomWidth = 1;
            this.pl_sound.Borders.LeftColor = System.Drawing.Color.Empty;
            this.pl_sound.Borders.LeftWidth = 1;
            this.pl_sound.Borders.RightColor = System.Drawing.Color.Empty;
            this.pl_sound.Borders.RightWidth = 1;
            this.pl_sound.Borders.TopColor = System.Drawing.Color.Empty;
            this.pl_sound.Borders.TopWidth = 1;
            this.pl_sound.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("pl_sound.Canvas")));
            this.pl_sound.Controls.Add(this.tkb_sound);
            this.pl_sound.Location = new System.Drawing.Point(111, 13);
            this.pl_sound.Name = "pl_sound";
            this.pl_sound.Size = new System.Drawing.Size(89, 34);
            this.pl_sound.TabIndex = 40;
            this.pl_sound.Visible = false;
            this.pl_sound.MouseLeave += new System.EventHandler(this.pl_sound_MouseLeave);
            // 
            // tkb_sound
            // 
            this.tkb_sound.AdaptImage = true;
            this.tkb_sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tkb_sound.BackImage = null;
            this.tkb_sound.BackLineColor = System.Drawing.Color.Gray;
            this.tkb_sound.Borders.BottomColor = System.Drawing.Color.Empty;
            this.tkb_sound.Borders.BottomWidth = 1;
            this.tkb_sound.Borders.LeftColor = System.Drawing.Color.Empty;
            this.tkb_sound.Borders.LeftWidth = 1;
            this.tkb_sound.Borders.RightColor = System.Drawing.Color.Empty;
            this.tkb_sound.Borders.RightWidth = 1;
            this.tkb_sound.Borders.TopColor = System.Drawing.Color.Empty;
            this.tkb_sound.Borders.TopWidth = 1;
            this.tkb_sound.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("tkb_sound.Canvas")));
            this.tkb_sound.ControlRectangle = new System.Drawing.Rectangle(5, 5, 40, 2);
            this.tkb_sound.LineWidth = 2;
            this.tkb_sound.Location = new System.Drawing.Point(30, 12);
            this.tkb_sound.MouseCanControl = true;
            this.tkb_sound.Name = "tkb_sound";
            this.tkb_sound.Orientation = LayeredSkin.Controls.Orientations.Horizontal;
            this.tkb_sound.PointImage = ((System.Drawing.Image)(resources.GetObject("tkb_sound.PointImage")));
            this.tkb_sound.PointImageHover = null;
            this.tkb_sound.PointImagePressed = null;
            this.tkb_sound.PointState = LayeredSkin.Controls.ControlStates.Normal;
            this.tkb_sound.Size = new System.Drawing.Size(50, 12);
            this.tkb_sound.SurfaceImage = null;
            this.tkb_sound.SurfaceLineColor = System.Drawing.Color.White;
            this.tkb_sound.TabIndex = 0;
            this.tkb_sound.Value = 0.5D;
            this.tkb_sound.ValueChanged += new System.EventHandler(this.tkb_sound_ValueChanged);
            // 
            // scorllbar
            // 
            this.scorllbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.scorllbar.Borders.BottomColor = System.Drawing.Color.Empty;
            this.scorllbar.Borders.BottomWidth = 1;
            this.scorllbar.Borders.LeftColor = System.Drawing.Color.Empty;
            this.scorllbar.Borders.LeftWidth = 1;
            this.scorllbar.Borders.RightColor = System.Drawing.Color.Empty;
            this.scorllbar.Borders.RightWidth = 1;
            this.scorllbar.Borders.TopColor = System.Drawing.Color.Empty;
            this.scorllbar.Borders.TopWidth = 1;
            this.scorllbar.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("scorllbar.Canvas")));
            this.scorllbar.Location = new System.Drawing.Point(407, -22);
            this.scorllbar.Name = "scorllbar";
            this.scorllbar.Size = new System.Drawing.Size(5, 151);
            this.scorllbar.TabIndex = 0;
            this.scorllbar.Visible = false;
            this.scorllbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scorllbar_MouseDown);
            this.scorllbar.MouseEnter += new System.EventHandler(this.scorllbar_MouseEnter);
            this.scorllbar.MouseLeave += new System.EventHandler(this.scorllbar_MouseLeave);
            this.scorllbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.scorllbar_MouseMove);
            this.scorllbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.scorllbar_MouseUp);
            this.scorllbar.Move += new System.EventHandler(this.scorllbar_Move);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "迷你音乐";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // FormMain
            // 
            this.AnimationType = LayeredSkin.Forms.AnimationTypes.Custom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CaptionShowMode = LayeredSkin.TextShowModes.None;
            this.ClientSize = new System.Drawing.Size(415, 505);
            this.Controls.Add(this.pl_bg);
            this.DrawIcon = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "迷你音乐，音乐我的生活！";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.pl_bg.ResumeLayout(false);
            this.pl_sound.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private LayeredSkin.Controls.LayeredCheckButton btn_soundsch;
        private LayeredSkin.Controls.LayeredPanel pl_bg;
        private LayeredSkin.Controls.LayeredPanel pl_sound;
        private LayeredSkin.Controls.LayeredTrackBar tkb_sound;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private LayeredSkin.Controls.LayeredBaseControl pl_playmodbg;
        private LayeredSkin.Controls.LayeredBaseControl scorllbar;
        private LayeredSkin.Controls.LayeredPictureBox pb_intro;
        public MyLayeredSkin.MusicList musicList1;
        private LayeredSkin.Controls.LayeredPictureBox pb_drawbar;
        private LayeredSkin.Controls.LayeredBaseControl pl_tip_container;
        private AutoDocker autoDocker1;
        public LayeredSkin.Controls.LayeredTrackBar tkb_basic;
    }
}

