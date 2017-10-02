using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class FormEq : Form
    {
        public FormEq(FormMain f)
        {
            InitializeComponent();
            fx = f;
        }
        FormMain fx = null;
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            eq1.Value = 0;
            eq2.Value = 0;
            eq4.Value = 0;
            eq3.Value = 0;
            eq6.Value = 0;
            eq5.Value = 0;
            eq8.Value = 0;
            eq7.Value = 0;
            eq10.Value = 0;
            eq9.Value = 0;
            button3.Enabled = false;
            updateeq();
        }
        private void FormEq_Load(object sender, EventArgs e)
        {
            if (!fx.Enableq)
            {
                layeredCheckButton1.Checked = false;
                eq1.Enabled = false;
                eq2.Enabled = false;
                eq3.Enabled = false;
                eq4.Enabled = false;
                eq5.Enabled = false;
                eq6.Enabled = false;
                eq7.Enabled = false;
                eq8.Enabled = false;
                eq9.Enabled = false;
                eq10.Enabled = false;
                button3.Enabled = false;
                comboBox1.Enabled = false;
            }
            else
            {
                layeredCheckButton1.Checked = true;
                eq1.Enabled = true;
                eq2.Enabled = true;
                eq3.Enabled = true;
                eq4.Enabled = true;
                eq5.Enabled = true;
                eq6.Enabled = true;
                eq7.Enabled = true;
                eq8.Enabled = true;
                eq9.Enabled = true;
                eq10.Enabled = true;
                button3.Enabled = true;
                comboBox1.Enabled = true;
            }

            comboBox1.SelectedIndex = 0;
            eq1.Value = fx.EQv[1];
            eq2.Value = fx.EQv[2];
            eq3.Value = fx.EQv[3];
            eq4.Value = fx.EQv[4];
            eq5.Value = fx.EQv[5];
            eq6.Value = fx.EQv[6];
            eq7.Value = fx.EQv[7];
            eq8.Value = fx.EQv[8];
            eq9.Value = fx.EQv[9];
            eq10.Value = fx.EQv[10];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            updateeq();
            Close();
        }
        private void updateeq()
        {
            fx.SetEQ(1, 80f, eq1.Value);
            fx.SetEQ(2, 170f, eq2.Value);
            fx.SetEQ(3, 370f, eq3.Value);
            fx.SetEQ(4, 600f, eq4.Value);
            fx.SetEQ(5, 1000f, eq5.Value);
            fx.SetEQ(6, 3000f, eq6.Value);
            fx.SetEQ(7, 6000f, eq7.Value);
            fx.SetEQ(8, 12000f, eq8.Value);
            fx.SetEQ(9, 14000f, eq9.Value);
            fx.SetEQ(10, 15000f, eq10.Value);
        }
        private void up()
        {
            if (button3.Enabled == false)
                button3.Enabled = true;
        }
        private void eq1_Scroll(object sender, EventArgs e)
        {
            fx.SetEQ(1, 80f, eq1.Value);
            up();
        }
        private void eq2_Scroll(object sender, EventArgs e)
        {
            fx.SetEQ(2, 170f, eq2.Value); up();
        }
        private void eq3_Scroll(object sender, EventArgs e)
        {
            fx.SetEQ(3, 370f, eq3.Value); up();
        }
        private void eq4_Scroll(object sender, EventArgs e)
        {
            fx.SetEQ(4, 600f, eq4.Value); up();
        }
        private void eq5_Scroll(object sender, EventArgs e)
        {
            fx.SetEQ(5, 1000f, eq5.Value); up();
        }
        private void eq6_Scroll(object sender, EventArgs e)
        {
            fx.SetEQ(6, 3000f, eq6.Value); up();
        }
        private void eq7_Scroll(object sender, EventArgs e)
        {
            fx.SetEQ(7, 6000f, eq7.Value); up();
        }
        private void eq8_Scroll(object sender, EventArgs e)
        {
            fx.SetEQ(8, 12000f, eq8.Value); up();
        }
        private void eq9_Scroll(object sender, EventArgs e)
        {
            fx.SetEQ(9, 14000f, eq9.Value); up();
        }
        private void eq10_Scroll(object sender, EventArgs e)
        {
            fx.SetEQ(10, 15000f, eq10.Value); up();
        }
        private void FormEq_Shown(object sender, EventArgs e)
        {
            Win32.SetForegroundWindow(Handle);

        }
        private void layeredCheckButton1_Click(object sender, EventArgs e)
        {
            if(layeredCheckButton1.Checked)
            {
                fx.Enableq = false;
                layeredCheckButton1.Checked = false;
                eq1.Enabled = false;
                eq2.Enabled = false;
                eq3.Enabled = false;
                eq4.Enabled = false;
                eq5.Enabled = false;
                eq6.Enabled = false;
                eq7.Enabled = false;
                eq8.Enabled = false;
                eq9.Enabled = false;
                eq10.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                comboBox1.Enabled = false;
            }
            else
            {
                fx.Enableq = true;
                layeredCheckButton1.Checked = true;
                eq1.Enabled = true;
                eq2.Enabled = true;
                eq3.Enabled = true;
                eq4.Enabled = true;
                eq5.Enabled = true;
                eq6.Enabled = true;
                eq7.Enabled = true;
                eq8.Enabled = true;
                eq9.Enabled = true;
                eq10.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                comboBox1.Enabled = true;
            }
        }
        private void eq1_SetV(int value)
        {
            eq1.Value = value;
            eq1_Scroll(null, null);
        }
        private void eq2_SetV(int value)
        {
            eq2.Value = value;
            eq2_Scroll(null, null);
        }
        private void eq3_SetV(int value)
        {
            eq3.Value = value;
            eq3_Scroll(null, null);
        }
        private void eq4_SetV(int value)
        {
            eq4.Value = value;
            eq4_Scroll(null, null);
        }
        private void eq5_SetV(int value)
        {
            eq5.Value = value;
            eq5_Scroll(null, null);
        }
        private void eq6_SetV(int value)
        {
            eq6.Value = value;
            eq6_Scroll(null, null);
        }
        private void eq7_SetV(int value)
        {
            eq7.Value = value;
            eq7_Scroll(null, null);
        }
        private void eq8_SetV(int value)
        {
            eq8.Value = value;
            eq8_Scroll(null, null);
        }
        private void eq9_SetV(int value)
        {
            eq9.Value = value;
            eq9_Scroll(null, null);
        }
        private void eq10_SetV(int value)
        {
            eq10.Value = value;
            eq10_Scroll(null, null);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                eq1_SetV(0);
                eq2_SetV(0);
                eq3_SetV(0);
                eq4_SetV(0);
                eq5_SetV(0);
                eq6_SetV(0);
                eq7_SetV(0);
            }
            else if (comboBox1.SelectedIndex == 1)
            {

            }
        }
    }
}
