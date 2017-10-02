using LayeredSkin.DirectUI;
using System;
using System.Collections.Generic;
using System.Drawing;

using System.Text;


namespace MusicPlayer.MyLayeredSkin
{
    public class MenudItem :LayeredSkin.DirectUI.DuiBaseControl
    {
        public MenudItem()
        {

            Size = new Size(205, 30);
            lb_text.Location = new Point(37, 8);
            lb_text.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            lb_text.Font = new Font("微软雅黑", 9f);
            pb_icon.Location = new Point(10, 8);
            pb_icon.Size = new Size(16, 16);
            lb_text.ForeColor = Color.FromArgb(102, 102, 102);
            lb_text.Size = new Size(140, 17);
            MouseEnter += MenuItem_MouseEnter;
            MouseLeave += MenuItem_MouseLeave;
            MouseClick += MenuItem_MouseClick;
            EnabledChanged += MenuItem_EnabledChanged;

            Controls.Add(lb_text);
            Controls.Add(pb_icon);
        }

        private void MenuItem_MouseClick(object sender, DuiMouseEventArgs e)
        {
            d = true;
        }
        private void MenuItem_EnabledChanged(object sender, EventArgs e)
        {
            if (!d)
            {
                if (Enabled)
                {
                    lb_text.ForeColor = Color.FromArgb(102, 102, 102);
                    pb_icon.Image = norimg;
                }
                else
                {
                    lb_text.ForeColor = Color.FromArgb(170, 170, 170);
                    pb_icon.Image = disimg;
                }
            }
        }
        private bool en = false;
        private bool d = false;
        private void MenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (!d)
            {
                BackColor = Color.White;
                pb_icon.Image = norimg;
                lb_text.ForeColor = Color.FromArgb(102, 102, 102);
                en = false;
            }
        }
        private void MenuItem_MouseEnter(object sender, EventArgs e)
        {
            if (!d)
            {
                BackColor = Color.FromArgb(20, 155, 240);
                lb_text.ForeColor = Color.White;
                pb_icon.Image = hovimg;
                en = true;
            }
        }

        private DuiLabel lb_text = new DuiLabel();
        private DuiPictureBox pb_icon = new DuiPictureBox();

        private Image norimg = null;
        private Image hovimg = null;
        private Image disimg = null;

        public Image NormalImage
        {
            get { return norimg; }
            set
            {
                norimg = value;
                if (Enabled)
                {
                    if (!en)
                        pb_icon.Image = value;
                }
            }
        }
        public Image HoverImage
        {
            get { return hovimg; }
            set
            {
                hovimg = value;
                if (Enabled)
                {
                    if (en)
                        pb_icon.Image = value;
                }
            }
        }
        public Image DisableImage
        {
            get { return disimg; }
            set
            {
                disimg = value;
                if (!Enabled)
                    pb_icon.Image = disimg;
            }
        }

        public string Text
        {
            get { return lb_text.Text; }
            set { lb_text.Text = value; }
        }
    }
}
