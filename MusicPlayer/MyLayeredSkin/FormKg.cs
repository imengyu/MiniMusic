using LayeredSkin.DirectUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MusicPlayer.MyLayeredSkin
{
    public partial class FormKg : Form
    {
        public FormKg()
        {
            InitializeComponent();
            loaddui();
            layeredPanel1.BackColor = Color.FromArgb(0, 150, 230);
            BackColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void FormKg_Load(object sender, EventArgs e)
        {
            
        }

        DuiButton btn_close = new DuiButton();
        DuiButton btn_min = new DuiButton();
        DuiLabel lb_text = new DuiLabel();

        [DefaultValue(true)]
        public bool EnableMiniButton
        {
            get { return btn_min.Visible; }
            set { btn_min.Visible = value; }
        }

        private void loaddui()
        {          
            lb_text.Size = new Size(300, 20);
            lb_text.Location = new Point(20, 12);
            lb_text.ForeColor = Color.White;
            lb_text.Font = new Font("微软雅黑", 10.5F, FontStyle.Regular);
            lb_text.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;

            //btn_close.Name = "btn_close";
            //btn_min.Name = "btn_min";
            //btn_close.Location = new Point(layeredPanel1.Width - 18, 12);
            //btn_min.Location = new Point(layeredPanel1.Width - 42, 12);
            //btn_close.NormalImage = Properties.Resources.btn_close_b_n;
            ///btn_close.HoverImage = Properties.Resources.btn_close_b_h;
            //btn_close.PressedImage = Properties.Resources.btn_close_b_p;
            //btn_min.NormalImage = Properties.Resources.btn_min_n;
            //btn_min.HoverImage = Properties.Resources.btn_min_h;
            //btn_min.PressedImage = Properties.Resources.btn_min_p;
            //btn_close.MouseClick += Btn_close_MouseClick;
            //btn_min.MouseClick += Btn_min_MouseClick;

            //layeredPanel1.DUIControls.Add(btn_close);
            //layeredPanel1.DUIControls.Add(btn_min);
            layeredPanel1.DUIControls.Add(lb_text);
        }

        private void Btn_min_MouseClick(object sender, DuiMouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Btn_close_MouseClick(object sender, DuiMouseEventArgs e)
        {
            Close();
        }

        public override string Text
        {
            get
            {
                return base.Text;
                //return lb_text.Text;
            }

            set
            {
                base.Text = value;
                lb_text.Text = value;
            }
        }

        private void layeredPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Win32.ReleaseCapture();
                Win32.SendMessage(Handle, 0xA1, 0x02, 0);
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int a = 150;
            g.FillRectangle(new SolidBrush(Color.FromArgb(a, a, a)), new Rectangle(0, 0, Width, 1));
            g.FillRectangle(new SolidBrush(Color.FromArgb(a, a, a)), new Rectangle(0, Height - 1, Width, 1));
            g.FillRectangle(new SolidBrush(Color.FromArgb(a, a, a)), new Rectangle(0, 0, 1, Height));
            g.FillRectangle(new SolidBrush(Color.FromArgb(a, a, a)), new Rectangle(Width - 1, 0, 1, Height));
            g.Dispose();
        }
        private void FormKg_SizeChanged(object sender, EventArgs e)
        {
            //try
            //{
                layeredPanel1.Width = Width - 2;
                //layeredPanel1.InnerDuiControl.FindControl("btn_min")[0].Left = Width - 50;
                sys_btn_close.Left = Width - 26;
            //}
            //catch { }
        }

        private void sys_btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
