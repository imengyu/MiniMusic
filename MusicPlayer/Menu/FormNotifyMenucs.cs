using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;

using System.Text;

using System.Windows.Forms;
using Un4seen.Bass;

namespace MusicPlayer
{
    public partial class FormNotifyMenucs : LayeredSkin.Forms.LayeredForm
    {
        public FormNotifyMenucs(FormMain m1)
        {
            InitializeComponent();
            m = m1;
            TopMost = true;
        }

        FormMain m = null;

        MyLayeredSkin.MenuItem i_exit = new MyLayeredSkin.MenuItem();
        MyLayeredSkin.MenuItem i_setting = new MyLayeredSkin.MenuItem();
        MyLayeredSkin.MenuItem i_locklrc = new MyLayeredSkin.MenuItem();
        MyLayeredSkin.MenuItem i_showlrc = new MyLayeredSkin.MenuItem();
        LayeredSkin.DirectUI.DuiBaseControl sp = new LayeredSkin.DirectUI.DuiBaseControl();
        LayeredSkin.DirectUI.DuiBaseControl sp2 = new LayeredSkin.DirectUI.DuiBaseControl();
        LayeredSkin.DirectUI.DuiBaseControl sp3 = new LayeredSkin.DirectUI.DuiBaseControl();

        LayeredSkin.DirectUI.DuiLabel lb_text = new LayeredSkin.DirectUI.DuiLabel();
        MyLayeredSkin.DuiCheckButton btn_playpause = new MyLayeredSkin.DuiCheckButton();
        MyLayeredSkin.DuiCheckButton btn_volzh = new MyLayeredSkin.DuiCheckButton();
        LayeredSkin.DirectUI.DuiButton btn_up = new LayeredSkin.DirectUI.DuiButton();
        LayeredSkin.DirectUI.DuiButton btn_next = new LayeredSkin.DirectUI.DuiButton();

        void a()
        {
            lb_text.Text = m.musicList1.IsPlayingText;
        }
        private void FormNotifyMenucs_Load(object sender, EventArgs e)
        {
            pl_base.BackColor = Color.White;
            btn_playpause.Location = new Point(90, 20);
            btn_up.Location = new Point(30, 25);
            btn_next.Location = new Point(150, 25);
            btn_volzh.Location = new Point(16, 100);
            lb_text.Size = new Size(215, 15);
            lb_text.Location = new Point(1, 70);
            lb_text.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            lb_text.Font = new Font("微软雅黑", 9f);
            lb_text.ForeColor = Color.FromArgb(102, 102, 102);
            lb_text.TextAlign = ContentAlignment.MiddleCenter;
            lb_text.Text = "迷你音乐，音乐我的生活！";
            i_exit.Location = new Point(5, 242);
            sp.Location = new Point(1, 235);
            sp.Size = new Size(Width - 1, 1);
            sp.BackColor = Color.FromArgb(230, 230, 230);
            sp2.Location = new Point(1, 194);
            sp2.Size = new Size(Width - 1, 1);
            sp2.BackColor = Color.FromArgb(230, 230, 230);
            sp3.Location = new Point(1, 124);
            sp3.Size = new Size(Width - 1, 1);
            sp3.BackColor = Color.FromArgb(230, 230, 230);
            i_locklrc.Location = new Point(5, 160);
            i_showlrc.Location = new Point(5, 130);
            i_setting.Location = new Point(5, 198);
            i_exit.Text = "退出";
            i_setting.Text = "设置";
            i_setting.NormalImage = Properties.Resources.i_setting_n;
            i_setting.HoverImage = Properties.Resources.i_setting_h;
            i_setting.DisableImage = Properties.Resources.i_setting_d;
            i_locklrc.Text = "锁定歌词";
            i_locklrc.Enabled = false;
            i_locklrc.NormalImage = Properties.Resources.i_locklrc_n;
            i_locklrc.HoverImage = Properties.Resources.i_locklrc_h;
            i_locklrc.DisableImage = Properties.Resources.i_locklrc_d;
            i_showlrc.Text = "显示歌词";//230
            i_showlrc.NormalImage = Properties.Resources.i_lrc_n;
            i_showlrc.HoverImage = Properties.Resources.i_lrc_h;
            i_showlrc.DisableImage = Properties.Resources.i_lrc_d;
            btn_playpause.CheckedNorImg = Properties.Resources.i_btn_pause_n_;
            btn_playpause.CheckedHovImg = Properties.Resources.i_btn_pause_h;
            btn_playpause.CheckedPreImg = Properties.Resources.i_btn_pause_p;
            btn_playpause.UnCheckedNorImg = Properties.Resources.i_btn_play_n;
            btn_playpause.UnCheckedHovImg = Properties.Resources.i_btn_play_h;
            btn_playpause.UnCheckedPreImg = Properties.Resources.i_btn_play_p;
            btn_up.NormalImage = Properties.Resources.i_up_n;
            btn_up.HoverImage = Properties.Resources.i_up_h;
            btn_up.PressedImage = Properties.Resources.i_up_p;
            btn_next.NormalImage = Properties.Resources.i_next_n;
            btn_next.HoverImage = Properties.Resources.i_next_h;
            btn_next.PressedImage = Properties.Resources.i_next_p;
            btn_volzh.CheckedNorImg = Properties.Resources.i_sound_dis_n;
            btn_volzh.CheckedHovImg = Properties.Resources.i_sound_dis_h;
            btn_volzh.CheckedPreImg = Properties.Resources.i_sound_dis_p;
            btn_volzh.UnCheckedNorImg = Properties.Resources.i_sound_n;
            btn_volzh.UnCheckedHovImg = Properties.Resources.i_sound_h;
            btn_volzh.UnCheckedPreImg = Properties.Resources.i_sound_p;
            btn_volzh.CheckOnClick = true;

            i_exit.MouseClick += I_exit_MouseClick;
            i_setting.MouseClick += I_setting_MouseClick;
            btn_playpause.MouseClick += Btn_playpause_MouseClick;
            btn_volzh.MouseClick += Btn_volzh_MouseClick;
            btn_next.MouseClick += Btn_next_MouseClick;
            btn_up.MouseClick += Btn_up_MouseClick;

            pl_base.DUIControls.Add(i_exit);
            pl_base.DUIControls.Add(i_setting);
            pl_base.DUIControls.Add(i_locklrc);
            pl_base.DUIControls.Add(i_showlrc);
            pl_base.DUIControls.Add(sp);
            pl_base.DUIControls.Add(sp2);
            pl_base.DUIControls.Add(sp3);
            pl_base.DUIControls.Add(lb_text);
            pl_base.DUIControls.Add(btn_playpause);
            pl_base.DUIControls.Add(btn_next);
            pl_base.DUIControls.Add(btn_up);
            pl_base.DUIControls.Add(btn_volzh);

            BASSActive b = Bass.BASS_ChannelIsActive(m.stream);
            if (b == BASSActive.BASS_ACTIVE_PLAYING)
            {
                btn_playpause.Checked = true;
            }
            else
            {
                btn_playpause.Checked = false;
            }

            if(m.Volume==0)
            {
                btn_volzh.Checked = true;
                layeredTrackBar1.Value = 0;
            }
            else
            {
                btn_volzh.Checked = false;
                layeredTrackBar1.Value = (double)m.Volume / 100;
            }
            a();
        }

        private void Btn_up_MouseClick(object sender, LayeredSkin.DirectUI.DuiMouseEventArgs e)
        {
            m.Btn_up_MouseClick(null, null);
            a();
        }
        private void Btn_next_MouseClick(object sender, LayeredSkin.DirectUI.DuiMouseEventArgs e)
        {
            m.Btn_next_MouseClick(null, null);
            a();
        }
        private void Btn_volzh_MouseClick(object sender, LayeredSkin.DirectUI.DuiMouseEventArgs e)
        {
            m.btn_soundsch_Click(null, null);
            if (m.Volume == 0)
            {
                btn_volzh.Checked = true;
                layeredTrackBar1.Value = 0;
            }
            else
            {
                btn_volzh.Checked = false;
                layeredTrackBar1.Value = (double)m.Volume / 100;
            }
        }
        private void Btn_playpause_MouseClick(object sender, LayeredSkin.DirectUI.DuiMouseEventArgs e)
        {
            if(btn_playpause.Checked)
            {
                btn_playpause.Checked = false;
                m.playpause(false);
            }
            else
            {
                btn_playpause.Checked = true;
                m.playpause(true);
            }
            a();
        }
        private void I_setting_MouseClick(object sender, LayeredSkin.DirectUI.DuiMouseEventArgs e)
        {
            WinMessageUntil.SendMessageToMusicPlayer("setting");
            Close();
        }
        private void I_exit_MouseClick(object sender, LayeredSkin.DirectUI.DuiMouseEventArgs e)
        {
            WinMessageUntil.SendMessageToMusicPlayer("exit");
            Close();
        }
        private void FormNotifyMenucs_Deactivate(object sender, EventArgs e)
        {
            Close();
        }
        private void layeredTrackBar1_Click(object sender, EventArgs e)
        {
            m.Volume = (int)(layeredTrackBar1.Value * 100);
        }
    }
}
