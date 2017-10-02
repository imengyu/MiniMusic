using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using System.Windows.Forms;

namespace MusicPlayer.Plugins
{
    public class QQDomainUpDown : ControlExs.QQTextBox
    {
        public QQDomainUpDown()
        {

        }
        bool enter = false;
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e); enter = true;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);enter = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if(enter)
            {
                if (IsInRect(new Rectangle(), MousePosition))
                {

                }
            }
            else
            {

            }
        }

        private bool IsInRect(Rectangle r,Point p)
        {
            if (p.X > r.X && p.X < r.X + r.Width && p.Y > r.Y && p.Y < r.Y + r.Height)
                return true;
            else
                return false;
        }

    }
}
