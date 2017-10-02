using LayeredSkin.DirectUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class FormSetting : MyLayeredSkin.FormKg
    {
        public FormSetting(FormMain f1)
        {
            InitializeComponent();
            m = f1;
        }
        FormMain m = null;
        private void FormSetting_Load(object sender, EventArgs e)
        {

            if (m.ExitWhenClose)
                qqRadioButton1.Checked = true;
            else
                qqRadioButton2.Checked = true;
            if (m.AutoPlay)
                qqCheckBox2.Checked = true;
            else
                qqCheckBox2.Checked = false;
            if (m.ExitWhenClose)
                qqRadioButton1.Checked = true;
            else
                qqRadioButton1.Checked = false;
            if (m.Enableq)
                qqCheckBox4.Checked = true;
            else
                qqCheckBox4.Checked = false;
            if (m.EnableSt)
                qqCheckBox5.Checked = true;
            else
                qqCheckBox5.Checked = false;
        }
        private void FormSetting_Shown(object sender, EventArgs e)
        {
            Win32.SetForegroundWindow(Handle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (qqCheckBox2.Checked)
                m.AutoPlay = true;
            else
                m.AutoPlay = false;
            if (qqRadioButton1.Checked)
                m.ExitWhenClose = true;
            else
                m.ExitWhenClose = false;
            if (qqCheckBox4.Checked)
                m.Enableq = true;
            else
                m.Enableq = false;
            if (qqCheckBox5.Checked)
                m.EnableSt = true;
            else
                m.EnableSt = false;
            Close();
        }
        private void qqCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WinMessageUntil.SendMessageToMusicPlayer("eq");
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\MusicPlayer.exe","-assion");
        }
       
    }
}
