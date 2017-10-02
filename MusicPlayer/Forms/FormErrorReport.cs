using LayeredSkin.DirectUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.IO;

using System.Text;

using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class FormErrorReport : LayeredSkin.Forms.LayeredForm
    {
        public FormErrorReport(string a)
        {
            InitializeComponent();aa = a;
        }
        string aa = "";
        private void FormErrorReport_Load(object sender, EventArgs e)
        {

        }
        private void layeredButton1_Click(object sender, EventArgs e)
        {
            Close(); if (File.Exists(Application.StartupPath + @"\" + aa))
                File.Delete(Application.StartupPath + @"\" + aa);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            if (File.Exists(Application.StartupPath + aa))
                File.Delete(Application.StartupPath + aa);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(File.Exists(Application.StartupPath + @"\MusicPlayerError.log"))
            {
                System.Diagnostics.Process.Start("notepad.exe", Application.StartupPath + @"\MusicPlayerError.log");
            }
        }

        private void FormErrorReport_Shown(object sender, EventArgs e)
        {
            try
            {
                layeredLabel3.BackColor = Color.FromArgb(10, 0, 0, 0);
                if (File.Exists(Application.StartupPath +  aa))
                {
                    StreamReader sr = new StreamReader(Application.StartupPath + aa,Encoding.Default);
                    ((DuiTextBox)layeredBaseControl1.InnerDuiControl.FindControl("tb_error")[0]).Text = sr.ReadToEnd();
                    sr.Close();
                }
                else
                {
                    ((DuiTextBox)layeredBaseControl1.InnerDuiControl.FindControl("tb_error")[0]).Text = "无法获取错误报告，该错误可能非常严重。";
                }
            }
            catch(Exception ee)
            {
                ((DuiTextBox)layeredBaseControl1.InnerDuiControl.FindControl("tb_error")[0]).Text = "获取错误报告失败，该错误可能非常严重。";
                throw ee;
            }
        }
    }
}
