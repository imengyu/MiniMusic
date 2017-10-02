using LayeredSkin.DirectUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;

using System.Text;

using System.Windows.Forms;
using Un4seen.Bass;

namespace MusicPlayer
{
    public partial class FormMini : LayeredSkin.Forms.LayeredForm
    {
        public FormMini(FormMain m1)
        {
            InitializeComponent();
            m = m1;
            m.OnMusicChanged += M_OnMusicChanged;
        }

        private void M_OnMusicChanged(object sender, EventArgs e)
        {
            pic.BackgroundImage = m.Alboum;
            l1.Text = m.Itext1; l2.Text = m.Itext2;
            BASSActive b = Bass.BASS_ChannelIsActive(m.stream);
            if (b == BASSActive.BASS_ACTIVE_PAUSED || b == BASSActive.BASS_ACTIVE_STOPPED)
            {
                playpause.Checked = false;
                
                timer1.Stop();
            }
            else if (b == BASSActive.BASS_ACTIVE_PLAYING)
            {
                playpause.Checked = true;
                timer1.Start();
            }

            if (l1.Width > 150)
            {
                l1.Left = 0;
                timer2.Start();
            }
            else
            {
                l1.Left = 150 / 2 - l1.Width / 2;
                timer2.Stop();
            }        
        }

        FormMain m = null;
        DuiBaseControl pic = new DuiBaseControl();
        DuiButton close = new DuiButton();
        DuiBaseControl pl_ctrl = new DuiBaseControl();
        DuiBaseControl traack = new DuiBaseControl();

        DuiLabel l1 = new DuiLabel();
        DuiLabel l2 = new DuiLabel();
        DuiLabel ltime= new DuiLabel();

        DuiButton back = new DuiButton();
        MyLayeredSkin.DuiCheckButton playpause = new MyLayeredSkin.DuiCheckButton();
        DuiButton next = new DuiButton();
        AutoDocker ad = new AutoDocker();

        private void FormMini_Load(object sender, EventArgs e)
        {
            Win32.SetWindowLongA(Handle, -20, Convert.ToInt32((Win32.GetWindowLong(Handle, -20) & (~0x00040000L) | 0x00000080L)));
            Win32.SetWindowPos(Handle, -1, 0, 0, 0, 0, 0x0002 | 0x0001);

            ad.Initialize(this, new Padding(22));

            pic.Size = new Size(50, 50);
            pic.Location = new Point();
            pic.BackgroundImageLayout = ImageLayout.Zoom;
            pic.BackgroundImage = Properties.Resources.默认;
            close.Location = new Point(220, 4);
            close.NormalImage = Properties.Resources.btn_close_black_n;
            close.HoverImage = Properties.Resources.btn_close_black_h;
            close.PressedImage = Properties.Resources.btn_close_black_p;
            close.MouseClick += Btn_close_MouseClick;

            back.Location = new Point(20, 13);
            back.NormalImage = Properties.Resources.btn_list_back_blk_n;
            back.HoverImage = Properties.Resources.btn_list_back_blk_h;
            back.PressedImage = Properties.Resources.btn_list_back_blk_p;
            back.MouseClick += Back_MouseClick;
            playpause.Location = new Point(45, 13);
            playpause.CheckedNorImg = Properties.Resources.btn_list_pause_blk_n;
            playpause.CheckedHovImg = Properties.Resources.btn_list_pause_blk_h;
            playpause.CheckedPreImg = Properties.Resources.btn_list_pause_blk_p;
            playpause.UnCheckedNorImg = Properties.Resources.btn_list_play_blk_n;
            playpause.UnCheckedHovImg = Properties.Resources.btn_list_play_blk_h;
            playpause.UnCheckedPreImg = Properties.Resources.btn_list_play_blk_p;
            playpause.MouseClick += Playpause_MouseClick;
            playpause.CheckOnClick = true; playpause.Size = new Size(16,16);
            next.Location = new Point(70, 13);
            next.NormalImage = Properties.Resources.btn_list_next_blk_n;
            next.HoverImage = Properties.Resources.btn_list_next_blk_h;
            next.PressedImage = Properties.Resources.btn_list_next_blk_p;
            next.MouseClick += Next_MouseClick;

            DuiBaseControl b1 = new DuiBaseControl();
            b1.Size = new Size(150, 20);
            b1.Location = new Point(55, 11);

            l1.Location = new Point(0, 0);
            l1.Text = "迷你音乐";
            l2.Text = "音乐我的生活1";
            l2.Location = new Point(55, 23);
            l1.AutoSize = true;

            l2.Size = new Size(150, 18);
            l2.ForeColor = Color.Gray;
            l1.TextAlign = ContentAlignment.MiddleCenter;
            l2.TextAlign = ContentAlignment.MiddleCenter;

            ltime.Text = "00:00/00:00";
            ltime.Location = new Point(88, 15);
            ltime.Size = new Size(80, 18);
            ltime.ForeColor = Color.Gray;
            ltime.TextAlign = ContentAlignment.MiddleCenter;

            DuiBaseControl valbk = new DuiBaseControl();
            valbk.Location = new Point(15, 40);
            valbk.Size = new Size(150, 2);
            valbk.BackColor = Color.FromArgb(100, 50, 60, 60);
            valbk.MouseClick += Traack_MouseClick;
            traack.MouseClick += Traack_MouseClick;
            traack.Location = new Point(15, 40);
            traack.Size = new Size(1, 2);
            traack.BackColor = Color.FromArgb(100, Color.FromArgb(0,109,192)); ;
            pl_ctrl.Size = new Size(165, 50);
            pl_ctrl.Location = new Point(50, 0);

            pl_ctrl.BackColor = Color.FromArgb(200, 255, 255, 255);
            pl_ctrl.Visible = false; pl_ctrl.Controls.Add(traack);
            pl_ctrl.Controls.Add(ltime); pl_ctrl.Controls.Add(valbk);
            pl_ctrl.Controls.Add(back);
            pl_ctrl.Controls.Add(playpause);
            pl_ctrl.Controls.Add(next);
            b1.Controls.Add(l1);

            pl_base.DUIControls.Add(l2);
            pl_base.DUIControls.Add(b1);
            pl_base.DUIControls.Add(close);
            pl_base.DUIControls.Add(pic);
            pl_base.DUIControls.Add(pl_ctrl);

            
        }

        private void Traack_MouseClick(object sender, DuiMouseEventArgs e)
        {
            m.setpos((double)e.X / (double)150);
        }
        private void Next_MouseClick(object sender, DuiMouseEventArgs e)
        {
            m.Btn_next_MouseClick(null, null);
        }
        private void Back_MouseClick(object sender, DuiMouseEventArgs e)
        {
            m.Btn_up_MouseClick(null, null);
        }
        private void Playpause_MouseClick(object sender, DuiMouseEventArgs e)
        {
            m.Btn_playpause_MouseClick(null, null);
        }
        private void Btn_close_MouseClick(object sender, DuiMouseEventArgs e)
        {
            Hide();
            WinMessageUntil.SendMessageToMusicPlayer("closemini");
        }
        bool Moveing = false;
        Point MovePoint = new Point();
        private void Pb_sinerimg_MouseDown(object sender, DuiMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Moveing = true;
                MovePoint = PointToClient(MousePosition);
            }
        }
        private void pl_base_MouseDown(object sender, MouseEventArgs e)
        {
            Pb_sinerimg_MouseDown(sender, new DuiMouseEventArgs(e.Button, e.Clicks, e.X, e.Y, e.Delta, true, null));
        }
        private void pl_base_MouseMove(object sender, MouseEventArgs e)
        {
            if (Moveing)
            {
                if (Top >= -5 && Left >= -5 && Top + Height <= Screen.PrimaryScreen.Bounds.Height && Left + Width <= Screen.PrimaryScreen.Bounds.Width + 5)
                    Location = new Point(MousePosition.X - MovePoint.X, MousePosition.Y - MovePoint.Y);
                else
                {
                    if (Top < -5)
                        Top = -5;
                    if (Left < -5)
                        Left = -5;
                    if (Top + Height > Screen.PrimaryScreen.Bounds.Height)
                        Top = Screen.PrimaryScreen.Bounds.Height - Height;
                    if (Left + Width > Screen.PrimaryScreen.Bounds.Width + 5)
                        Left = Screen.PrimaryScreen.Bounds.Width + 5 - Width;
                    MovePoint = PointToClient(MousePosition);
                }
            }
        }
        private void pl_base_MouseUp(object sender, MouseEventArgs e)
        {
            Moveing = false;
        }
        private void pl_base_MouseEnter(object sender, EventArgs e)
        {
            pl_ctrl.Visible = true;
        }
        private void pl_base_MouseLeave(object sender, EventArgs e)
        {
            pl_ctrl.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ltime.Text = m.Itime;
            traack.Width = (int)(m.tkb_basic.Value * 150);
        }
        private void FormMini_Shown(object sender, EventArgs e)
        {
            M_OnMusicChanged(null, null);           
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (l1.Left > -l1.Width - 5)
            {
                l1.Left = l1.Left - 10;
            }
            else
            {
                l1.Left = 155;
            }
        }
    }
}
