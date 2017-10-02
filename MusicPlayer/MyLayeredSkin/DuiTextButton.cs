using LayeredSkin.DirectUI;
using System;
using System.Collections.Generic;

using System.Text;


namespace MusicPlayer.MyLayeredSkin
{
    public class DuiTextButton : DuiBaseControl
    {
        public DuiTextButton()
        {
            Size = new System.Drawing.Size(125, 30);
            pb_icon.Size = new System.Drawing.Size(22, 22);
            lb_text.Size = new System.Drawing.Size(60, 20);
            lb_text.ForeColor = System.Drawing.Color.FromArgb(200, System.Drawing.Color.White);
            lb_text.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            lb_text.Font = new System.Drawing.Font("微软雅黑", 9F);
            pb_icon.Location = new System.Drawing.Point(10, 6);
            lb_text.Location = new System.Drawing.Point(40, 8);
            base.MouseEnter += DuiTextButton_MouseEnter;
            base.MouseLeave += DuiTextButton_MouseLeave;

            Controls.Add(lb_text);
            Controls.Add(pb_icon);
        }

        private void DuiTextButton_MouseLeave(object sender, EventArgs e)
        {
            pb_icon.Image = norimg;
            lb_text.ForeColor = System.Drawing.Color.FromArgb(200, System.Drawing.Color.White);
        }
        private void DuiTextButton_MouseEnter(object sender, EventArgs e)
        {
            pb_icon.Image = hovimg;
            lb_text.ForeColor = System.Drawing.Color.FromArgb(255, System.Drawing.Color.White);
        }

        DuiLabel lb_text = new DuiLabel();
        DuiPictureBox pb_icon = new DuiPictureBox();

        System.Drawing.Image norimg = null;
        System.Drawing.Image hovimg = null;

        public string Text
        {
            get { return lb_text.Text; }
            set { lb_text.Text = value; }
        }
        public System.Drawing.Image NormalImage
        {
            get
            {
                return norimg;
            }
            set
            {
                norimg = value;
                pb_icon.Image = value;
            }
        }
        public System.Drawing.Image HoverImage
        {
            get
            {
                return hovimg;
            }
            set
            {
                hovimg = value;
            }
        }
    }
}
