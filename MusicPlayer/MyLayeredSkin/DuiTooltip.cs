using LayeredSkin.DirectUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MusicPlayer.MyLayeredSkin
{
    public class DuiTooltip : Component
    {
        System.Windows.Forms.ToolTip tip;
        System.Windows.Forms.Form wnd = new System.Windows.Forms.Form();
        public DuiTooltip(System.Windows.Forms.Form wnd1)
        {
            tip = new System.Windows.Forms.ToolTip();
            wnd = wnd1;           
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool GetCursorPos(out System.Drawing.Point pt);

        public struct DuiTooltipText
        {
            public string Name;
            public string TipText;
        }

        [DefaultValue(5000)]
        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        private int duration = 5000;
        private List<DuiTooltipText> list = new List<DuiTooltipText>();

        public void Initialize(DuiBaseControl control, string text)
        {
            control.MouseEnter += Control_MouseEnter;
            control.MouseLeave += Control_MouseLeave;
            DuiTooltipText l = new DuiTooltipText();
            l.Name = control.Name;
            l.TipText = text;
            list.Add(l);
        }
        private void Control_MouseLeave(object sender, EventArgs e)
        {
            tip.Hide(wnd);
        }
        private void Control_MouseEnter(object sender, EventArgs e)
        {
            tip.Hide(wnd);
            
            foreach (DuiTooltipText d in list)
            {
                if (d.Name == ((DuiBaseControl)sender).Name)
                {
                    System.Drawing.Point p = new System.Drawing.Point();
                    GetCursorPos(out p);
                    tip.ToolTipTitle = d.TipText;
                    tip.Show(d.TipText, wnd, wnd.PointToClient(new System.Drawing.Point(p.X + 10, p.Y + 5)), duration);
                }
            }
        }
        public void UnInitialize(DuiBaseControl control)
        {
            control.MouseEnter -= Control_MouseEnter;
            control.MouseLeave -= Control_MouseLeave;
            foreach(DuiTooltipText d in list)
            {
                if(d.Name==control.Name)
                {
                    list.Remove(d);
                }
            }
        }
    }
}
