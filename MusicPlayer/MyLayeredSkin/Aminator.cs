using LayeredSkin;
using LayeredSkin.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MusicPlayer.MyLayeredSkin
{
    public class Aminator
    {
        Timer t = new Timer();
        public Aminator(LayeredSkin.Controls.LayeredBaseControl c1,bool show)
        {
            t.Interval = 40;
            t.Tick += T_Tick;
            c = c1;sh = show;
            if(!show)
                a = 1;
        }
        float a = 0;
        bool sh = false;
        LayeredSkin.Controls.LayeredBaseControl c = null;
        private void T_Tick(object sender, EventArgs e)
        {
            if (sh)
            {
                if(a<1)
                {
                    a += 0.06f;
                    c.ImageAttribute = ImageEffects.ChangeOpacity(a);
                    
                }
                else
                {
                    a = 1;
                    t.Stop();
                }
            }
            else
            {
                if (a > 0)
                {
                    a -= 0.06f;
                    c.ImageAttribute = ImageEffects.ChangeOpacity(a);
                    
                }
                else
                {
                    a = 0;
                    t.Stop();
                    c.Hide();
                }            
            }
            ((LayeredForm)c.FindForm()).LayeredPaint();
        }

        public void StartAmin()
        {
            if (!c.Visible)
                c.Show();
            t.Start();
        }
    }
}
