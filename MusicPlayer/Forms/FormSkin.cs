using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class FormSkin : LayeredSkin.Forms.LayeredForm
    {
        public FormSkin(FormMain f)
        {
            InitializeComponent();
            fm = f;
        }
        FormMain fm = null;
        private void FormSkin_Load(object sender, EventArgs e)
        {
            tkb_skin.Value = (double)(fm.Transparency) / 255;
        }
        private void pl_skin_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btn_skinclose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormSkin_Deactivate(object sender, EventArgs e)
        {
            if (dialoga == false)
                Close();
        }
        private void pictureBox31_MouseEnter(object sender, EventArgs e)
        {

        }
        private void pictureBox31_MouseLeave(object sender, EventArgs e)
        {

        }
        private void layeredCheckButton1_Click(object sender, EventArgs e)
        {
            if(fm.EnabledDWM)
            {
                fm.EnabledDWM = false;
            }
            else
            {
                fm.EnabledDWM = true;
            }
        }
        private void pictureBox30_Click(object sender, EventArgs e)
        {
            fm.BackColor = Color.FromArgb((int)(255 * (1 - tkb_skin.Value)), ((PictureBox)sender).BackColor);
            fm.BackCl = fm.BackColor;
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "图片文件|*.png;*.jpg;*.bmp";
            op.Title = "打开图片";
            if (op.ShowDialog() == DialogResult.OK)
            {
                fm.BackGroundSkin = op.FileName;
            }
        }
        bool dialoga = false;
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            dialoga = true;
            if (colorDialog1.ShowDialog()== DialogResult.OK)
            {
                fm.BackColor = Color.FromArgb((int)(255 * (1 - tkb_skin.Value)), colorDialog1.Color);
                fm.BackCl = fm.BackColor;
                dialoga = false;
            }
        }
        private void tkb_skin_ValueChanged(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_Click(object sender, EventArgs e)
        {
            fm.BackGroundSkin = Application.StartupPath + "\\skins\\0.png";
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fm.BackGroundSkin = Application.StartupPath + "\\skins\\5.png";
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            fm.BackGroundSkin = Application.StartupPath + "\\skins\\3.png";
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            fm.BackGroundSkin = Application.StartupPath + "\\skins\\6.png";
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fm.BackGroundSkin = Application.StartupPath + "\\skins\\4.png";
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            fm.BackGroundSkin = Application.StartupPath + "\\skins\\2.png";
        }
        private void pictureBox15_MouseDown(object sender, MouseEventArgs e)
        {
            fm.BackGroundSkin = "N/A";
        }
        private void tkb_skin_MouseUp(object sender, MouseEventArgs e)
        {
            lb_skintr.Text = (tkb_skin.Value * 100).ToString("0") + "%";
            fm.BackColor = Color.FromArgb((int)(255 * (1 - tkb_skin.Value)), fm.BackColor);
            fm.BackCl = fm.BackColor;
            fm.Transparency = (int)(255 * (1 - tkb_skin.Value));
        }
    } 
}