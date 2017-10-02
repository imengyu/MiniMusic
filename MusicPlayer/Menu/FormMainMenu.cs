using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class FormMainMenu : LayeredSkin.Forms.LayeredForm
    {
        public FormMainMenu()
        {
            InitializeComponent();
            //Control.CheckForIllegalCrossThreadCalls = false;
        }

        MyLayeredSkin.MenuItem i_exit = new MyLayeredSkin.MenuItem();
        MyLayeredSkin.MenuItem i_setting = new MyLayeredSkin.MenuItem();
        MyLayeredSkin.MenuItem i_addfile = new MyLayeredSkin.MenuItem();
        MyLayeredSkin.MenuItem i_addfolder = new MyLayeredSkin.MenuItem();
        MyLayeredSkin.MenuItem i_eq = new MyLayeredSkin.MenuItem();
        MyLayeredSkin.MenuItem i_update = new MyLayeredSkin.MenuItem();
        MyLayeredSkin.MenuItem i_about = new MyLayeredSkin.MenuItem();
        MyLayeredSkin.MenuItem i_mini = new MyLayeredSkin.MenuItem();

        LayeredSkin.DirectUI.DuiBaseControl sp = new LayeredSkin.DirectUI.DuiBaseControl();
        LayeredSkin.DirectUI.DuiBaseControl sp2 = new LayeredSkin.DirectUI.DuiBaseControl();
        LayeredSkin.DirectUI.DuiBaseControl sp3 = new LayeredSkin.DirectUI.DuiBaseControl();

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            TopMost = true;
            pl_base.BackColor = Color.White;
            i_addfile.Text = "添加音乐...";
            i_addfolder.Text = "添加音乐文件夹...";
            i_setting.Text = "设置";
            i_eq.Text = "均衡器";
            i_update.Text = "在线升级";
            i_about.Text = "关于...";
            i_exit.Text = "退出程序";
            i_mini.Text = "超迷你模式";
            i_addfile.Location = new Point(5, 5);
            i_addfolder.Location = new Point(5, 40);
            sp.Location = new Point(1, 75);
            sp.Size = new Size(214, 1);
            sp.BackColor = Color.FromArgb(230, 230, 230);
            i_setting.Location = new Point(5, 80);
            i_setting.NormalImage = Properties.Resources.i_setting_n;
            i_setting.HoverImage = Properties.Resources.i_setting_h;
            i_setting.DisableImage = Properties.Resources.i_setting_d;
            i_eq.Location = new Point(5, 110);
            i_eq.NormalImage = Properties.Resources.i_eq_n;
            i_eq.HoverImage = Properties.Resources.i_eq_h;
            i_eq.DisableImage = Properties.Resources.i_eq_dis;
            i_mini.Location = new Point(5, 140);
            sp2.Location = new Point(1, 175);
            sp2.Size = new Size(214, 1);
            sp2.BackColor = Color.FromArgb(230, 230, 230);
            i_update.Location = new Point(5, 180);
            i_about.Location = new Point(5, 210);
            sp3.Location = new Point(1, 245);
            sp3.Size = new Size(214, 1);
            sp3.BackColor = Color.FromArgb(230, 230, 230);
            i_exit.Location = new Point(5, 250);
            i_exit.NormalImage = Properties.Resources.i_exit_n;
            i_exit.HoverImage = Properties.Resources.i_exit_h;
            i_exit.DisableImage = Properties.Resources.i_exit_d;

            i_exit.MouseClick += I_exit_MouseClick;
            i_setting.MouseClick += I_setting_MouseClick;
            i_eq.MouseClick += I_eq_MouseClick;
            i_addfile.MouseClick += I_addfile_MouseClick;
            i_addfolder.MouseClick += I_addfolder_MouseClick;
            i_about.MouseClick += I_about_MouseClick;
            i_update.MouseClick += I_update_MouseClick;
            i_mini.MouseClick += I_mini_MouseClick;

            pl_base.DUIControls.Add(i_exit);
            pl_base.DUIControls.Add(i_setting);
            pl_base.DUIControls.Add(i_addfile);
            pl_base.DUIControls.Add(i_addfolder);
            pl_base.DUIControls.Add(i_eq);
            pl_base.DUIControls.Add(i_update);
            pl_base.DUIControls.Add(i_about);
            pl_base.DUIControls.Add(i_mini);

            pl_base.DUIControls.Add(sp);
            pl_base.DUIControls.Add(sp2);
            pl_base.DUIControls.Add(sp3);

            Size = new Size(215, 285);
            pl_base.Size = new Size(215, 285);

        }

        private void I_mini_MouseClick(object sender, LayeredSkin.DirectUI.DuiMouseEventArgs e)
        {
            WinMessageUntil.SendMessageToMusicPlayer("mini");
            Close();
        }

        public void ShowW(Point p)
        {        
            Show();
            Location = p;
        }


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            /*i_exit.MouseClick -= I_exit_MouseClick;
            i_setting.MouseClick -= I_setting_MouseClick;
            i_eq.MouseClick -= I_eq_MouseClick;
            i_addfile.MouseClick -= I_addfile_MouseClick;
            i_addfolder.MouseClick -= I_addfolder_MouseClick;
            i_about.MouseClick -= I_about_MouseClick;
            i_update.MouseClick -= I_update_MouseClick;8*/

            /*i_exit.Dispose();
            i_setting.Dispose();
            i_addfile.Dispose();
            i_addfolder.Dispose();
            i_eq.Dispose();
            i_update.Dispose();
            i_about.Dispose();

            pl_base.DUIControls.Remove(i_exit);
            pl_base.DUIControls.Remove(i_setting);
            pl_base.DUIControls.Remove(i_addfile);
            pl_base.DUIControls.Remove(i_addfolder);
            pl_base.DUIControls.Remove(i_eq);
            pl_base.DUIControls.Remove(i_update);
            pl_base.DUIControls.Remove(i_about);
            pl_base.DUIControls.Remove(sp);
            pl_base.DUIControls.Remove(sp2);
            pl_base.DUIControls.Remove(sp3);*/

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void I_update_MouseClick(object sender, LayeredSkin.DirectUI.DuiMouseEventArgs e)
        {
            WinMessageUntil.SendMessageToMusicPlayer("update");
            Close();
        }
        private void I_about_MouseClick(object sender, LayeredSkin.DirectUI.DuiMouseEventArgs e)
        {
            WinMessageUntil.SendMessageToMusicPlayer("about");
            Close();
        }
        private void I_addfolder_MouseClick(object sender, LayeredSkin.DirectUI.DuiMouseEventArgs e)
        {
            WinMessageUntil.SendMessageToMusicPlayer("addfolder");
            Close();
        }
        private void I_addfile_MouseClick(object sender, LayeredSkin.DirectUI.DuiMouseEventArgs e)
        {
            WinMessageUntil.SendMessageToMusicPlayer("addfile");
            Close();
        }
        private void I_eq_MouseClick(object sender, LayeredSkin.DirectUI.DuiMouseEventArgs e)
        {
            WinMessageUntil.SendMessageToMusicPlayer("eq");
            Close();
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
    }
}
