using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;

using System.Text;
using LayeredSkin.DirectUI;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class FormExitArsk : LayeredSkin.Forms.LayeredForm
    {
        public FormExitArsk(bool a)
        {
            InitializeComponent();
            aa = a;
        }
        bool aa = false;
        DuiRadioButton ra1 = new DuiRadioButton();
        DuiRadioButton ra2 = new DuiRadioButton();
        DuiCheckBox ch1 = new DuiCheckBox();
        DuiLabel lb = new DuiLabel();
        DuiButton btnok = new DuiButton();
        DuiButton close = new DuiButton();
        DuiBaseControl sp = new DuiBaseControl();

        private void FormExitArsk_Load(object sender, EventArgs e)
        {
            close.Location = new Point(220, 7);
            close.NormalImage = Properties.Resources.btn_close_sys_n;
            close.HoverImage = Properties.Resources.btn_close_sys_h;
            close.PressedImage = Properties.Resources.btn_close_sys_p;
            close.MouseClick += Close_MouseClick;
            lb.Location = new Point(30, 45);
            lb.Size = new Size(200,23);
            lb.Text = "点击关闭按钮时：";
            ra1.Location = new Point(30, 65);
            ra1.Text = "最小化到托盘图标";
            ra1.CheckRectBackColorNormal = Color.White;
            ra1.CheckRectBackColorHighLight = Color.FromArgb(20,0,0,0);
            ra1.CheckRectBackColorPressed = Color.White;
            ra1.Font = new Font("微软雅黑", 9f);
            ra2.Location = new Point(30, 90);
            ra2.Text = "退出程序";
            ra2.Font = new Font("微软雅黑", 9f);
            ra2.CheckRectBackColorNormal = Color.White;
            ra2.CheckRectBackColorHighLight = Color.FromArgb(20, 0, 0, 0);
            ra2.CheckRectBackColorPressed = Color.White;
            ch1.Location = new Point(13, 130);
            ch1.Text = "不要再提醒我";
            ch1.Font = new Font("微软雅黑", 9f);
            ch1.CheckRectBackColorNormal = Color.White;
            ch1.CheckRectBackColorHighLight = Color.FromArgb(20, 0, 0, 0);
            ch1.CheckRectBackColorPressed = Color.White;

            if (aa)
                ra2.Checked = true;
            else
                ra1.Checked = true;

            sp.Location = new Point(0, 123);
            sp.Size = new Size(Width, 1);
            sp.BackColor = Color.FromArgb(50, 0, 0, 0);

            btnok.Location = new Point(154, 126);
            btnok.Text = "确定";
            btnok.NormalImage = Properties.Resources.button_white_normal;
            btnok.HoverImage = Properties.Resources.button_white_hover;
            btnok.PressedImage = Properties.Resources.button_white_click;
            btnok.MouseClick += Btnok_MouseClick;
            layeredBaseControl1.DUIControls.Add(close);
            layeredBaseControl1.DUIControls.Add(btnok);
            layeredBaseControl1.DUIControls.Add(ch1);
            layeredBaseControl1.DUIControls.Add(lb);
            layeredBaseControl1.DUIControls.Add(ra1);
            layeredBaseControl1.DUIControls.Add(ra2);
            layeredBaseControl1.DUIControls.Add(sp);
        }
        bool save = false;
        bool exit = false;
        bool cancel = false;
        public bool Cancel
        {
            get { return cancel; }
        }
        public bool Exit
        {
            get { return exit; }
        }
        public bool Save
        {
            get { return save; }
        }
        private void Btnok_MouseClick(object sender, DuiMouseEventArgs e)
        {
            save = !ch1.Checked;
            exit = ra2.Checked;
            Close();
        }
        private void Close_MouseClick(object sender, DuiMouseEventArgs e)
        {
            cancel = true;
            Close();
        }
    }
}
