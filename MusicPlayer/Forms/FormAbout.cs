using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }
        private Plugins.Button button2;
        private PictureBox layeredPictureBox1;
        private PictureBox layeredPictureBox2;
        private Label label2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel5;
        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Label label1;
        private Label label5;
        private Panel panel3;
        private LinkLabel linkLabel7;
        private LinkLabel linkLabel3;
        private void FormAbout_Load(object sender, EventArgs e)
        {
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.button2 = new MusicPlayer.Plugins.Button();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.layeredPictureBox1 = new System.Windows.Forms.PictureBox();
            this.layeredPictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.layeredPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layeredPictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.HoverImage = global::MusicPlayer.Properties.Resources.button_white_hover;
            this.button2.Location = new System.Drawing.Point(326, 497);
            this.button2.Name = "button2";
            this.button2.NormalImage = global::MusicPlayer.Properties.Resources.button_white_normal;
            this.button2.Palace = new System.Windows.Forms.Padding(5);
            this.button2.PressImage = global::MusicPlayer.Properties.Resources.button_white_click;
            this.button2.Size = new System.Drawing.Size(97, 27);
            this.button2.SizeMode = MusicPlayer.Plugins.Button.ButtonImageMode.Palace;
            this.button2.TabIndex = 4;
            this.button2.Text = "确定";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel3.ForeColor = System.Drawing.Color.Black;
            this.linkLabel3.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel3.Location = new System.Drawing.Point(32, 497);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(68, 17);
            this.linkLabel3.TabIndex = 5;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "关于制作者";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // layeredPictureBox1
            // 
            this.layeredPictureBox1.BackgroundImage = global::MusicPlayer.Properties.Resources.musicplayer;
            this.layeredPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.layeredPictureBox1.Location = new System.Drawing.Point(33, 29);
            this.layeredPictureBox1.Name = "layeredPictureBox1";
            this.layeredPictureBox1.Size = new System.Drawing.Size(65, 60);
            this.layeredPictureBox1.TabIndex = 6;
            this.layeredPictureBox1.TabStop = false;
            this.layeredPictureBox1.Text = "layeredPictureBox1";
            // 
            // layeredPictureBox2
            // 
            this.layeredPictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("layeredPictureBox2.BackgroundImage")));
            this.layeredPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredPictureBox2.Location = new System.Drawing.Point(113, 25);
            this.layeredPictureBox2.Name = "layeredPictureBox2";
            this.layeredPictureBox2.Size = new System.Drawing.Size(255, 80);
            this.layeredPictureBox2.TabIndex = 8;
            this.layeredPictureBox2.TabStop = false;
            this.layeredPictureBox2.Text = "layeredPictureBox2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Copright © 2016 MagicGame™.All Rights Reserved.\r\n";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabel1.Location = new System.Drawing.Point(-1, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(259, 34);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Zlib 1.1.3.0 \r\n(C) 1995-1998 Jean-loup Gailly & Mark Adler";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabel2.Location = new System.Drawing.Point(-1, 46);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(233, 34);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Newtonsoft.Json \r\nCopyright © James Newton-King 2008";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel4.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabel4.Location = new System.Drawing.Point(-1, 92);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(336, 51);
            this.linkLabel4.TabIndex = 14;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "APlayer_3.9.0.761\r\nCopyright (c) 2005-2015 ShenZhen Thunder Networking \r\nTechnolo" +
    "gies, LTD";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel5.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabel5.Location = new System.Drawing.Point(-1, 154);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(78, 17);
            this.linkLabel5.TabIndex = 15;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "LayeredSkin";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.linkLabel7);
            this.panel1.Controls.Add(this.linkLabel5);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel4);
            this.panel1.Location = new System.Drawing.Point(33, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 148);
            this.panel1.TabIndex = 17;
            // 
            // linkLabel7
            // 
            this.linkLabel7.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel7.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabel7.Location = new System.Drawing.Point(0, 182);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(356, 36);
            this.linkLabel7.TabIndex = 18;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "CSharp Read and write ID3v1 and ID3v2 data Libary\r\n(C) Hamed J.I";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "软件免责声明：";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(33, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 75);
            this.panel2.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 106);
            this.label4.TabIndex = 20;
            this.label4.Text = "本软件制作之初仅为学习之用，本产品中提供的软件之著作权归软件作者所有，软件服务权益归服务提供商所有。用户可以自由选择是否使用本产品提供的软件。如果用户下载、安装、" +
    "使用本产品中所提供的软件，即表明用户信任该软件作者，对任何原因在使用本产品中提供的软件时可能对用户自己或他人造成的任何形式的损失和伤害不承担责任。";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 68);
            this.label1.TabIndex = 10;
            this.label1.Text = "MiniMusic Version 1.8.68.1766\r\n\r\n一款炫酷，精简，迷你的音乐播放器。\r\n本软件其中用到了以下第三方软件：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(33, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "本软件严禁用于任何商业用途。";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.layeredPictureBox2);
            this.panel3.Controls.Add(this.layeredPictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 114);
            this.panel3.TabIndex = 21;
            // 
            // FormAbout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 536);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关于迷你音乐";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.Shown += new System.EventHandler(this.FormAbout_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.layeredPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layeredPictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.cskin.net");
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.kugou.com");
        }

        private void FormAbout_Shown(object sender, EventArgs e)
        {
            Win32.SetForegroundWindow(Handle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("MadeBy yuzecheng");
        }

        private void layeredBaseControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left)
            {
                Win32.ReleaseCapture();
                Win32.SendMessage(Handle, 0xA1, 0x02, 0);
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://aplayer.open.xunlei.com/");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.kugou.com");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.kugou.com");
        }
    }
}
