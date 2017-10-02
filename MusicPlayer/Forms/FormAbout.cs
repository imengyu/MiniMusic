using LayeredSkin.DirectUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class FormAbout : MyLayeredSkin.FormKg
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        DuiPictureBox pb_icon = new DuiPictureBox();
        DuiLabel lb_title = new DuiLabel();
        private LayeredSkin.Controls.LayeredBaseControl layeredBaseControl1;
        DuiLabel lb_title2 = new DuiLabel();
        DuiLabel lb_text1 = new DuiLabel();
        DuiLabel lb_text2 = new DuiLabel();
        DuiLabel lb_text3 = new DuiLabel();
        DuiLabel lb_text4 = new DuiLabel();
        DuiLabel lb_text5 = new DuiLabel();
        DuiLabel lb_text6 = new DuiLabel();
        DuiPictureBox pb_crea1 = new DuiPictureBox();
        DuiPictureBox pb_crea2 = new DuiPictureBox();
        DuiPictureBox pb_crea3 = new DuiPictureBox();
        DuiButton btn_1 = new DuiButton();
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Plugins.Button button2;
        private LinkLabel linkLabel3;
        DuiButton btn_2 = new DuiButton();
        private void FormAbout_Load(object sender, EventArgs e)
        {
            pb_icon.Location = new Point(10, 10);
            pb_icon.Size = new Size(50, 50);
            pb_icon.BackgroundImage = Properties.Resources.musicplayerbig;
            pb_icon.BackgroundImageLayout = ImageLayout.Zoom;

            lb_title.Location = new Point(65, 10);
            lb_title.Text = "迷你音乐";
            lb_title.Font = new Font("微软雅黑", 14f);
            lb_title.Size = new Size(180, 50);
            lb_title.ForeColor = Color.Black;
            lb_title.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;
            
            lb_title2.Location = new Point(65, 40);
            lb_title2.Text = "Mini MusicPlayer - We Do the most simple music player.";
            lb_title2.Font = new Font("微软雅黑", 10.5f);
            lb_title2.Size = new Size(475, 30);
            lb_title2.ForeColor = Color.FromArgb(122, 122, 122);
            lb_title2.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;

            DuiBaseControl sp = new DuiBaseControl();
            sp.Size = new Size(400, 1);
            sp.Location = new Point(65, 75);
            sp.BackColor = Color.FromArgb(80, 0, 0, 0);
            layeredBaseControl1.DUIControls.Add(sp);

            lb_text1.Location = new Point(65, 80);
            lb_text1.Text = "版本：" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            lb_text1.Font = new Font("微软雅黑", 9f);
            lb_text1.Size = new Size(475, 30);
            lb_text1.ForeColor = Color.FromArgb(102, 102, 102);
            lb_text1.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;

            lb_text2.Location = new Point(65, 100);
            lb_text2.Text = "Build Version：1.0.3.6";
            lb_text2.Font = new Font("微软雅黑", 9f);
            lb_text2.Size = new Size(475, 30);
            lb_text2.ForeColor = Color.FromArgb(102, 102, 102);
            lb_text2.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;

            lb_text3.Location = new Point(65, 130);
            lb_text3.Text = "Copright © 2016 MagicGame™.All Rights Reserved.";
            lb_text3.Font = new Font("微软雅黑", 9f);
            lb_text3.Size = new Size(475, 30);
            lb_text3.ForeColor = Color.FromArgb(132, 132, 132);
            lb_text3.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;

            lb_text5.Location = new Point(65, 150);
            lb_text5.Text = "特别鸣谢：";
            lb_text5.Font = new Font("微软雅黑", 9f);
            lb_text5.Size = new Size(105, 30);
            lb_text5.ForeColor = Color.FromArgb(132, 132, 132);
            lb_text5.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;

            pb_crea1.Location = new Point(65, 170);
            pb_crea1.Size = new Size(278, 71);
            pb_crea1.BackgroundImage = Properties.Resources.poweredbylskin;
            pb_crea1.BackgroundImageLayout = ImageLayout.Zoom;

            lb_text6.Location = new Point(85, 245);
            lb_text6.Text = "Online music search service Powered By";
            lb_text6.Font = new Font("微软雅黑", 9f);
            lb_text6.Size = new Size(150, 60);
            lb_text6.ForeColor = Color.Black;
            lb_text6.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;

            pb_crea2.Location = new Point(85, 250);
            pb_crea2.Size = new Size(360, 91);
            pb_crea2.BackgroundImage = Properties.Resources.kg2;
            pb_crea2.BackgroundImageLayout = ImageLayout.Zoom;
            //pb_crea3.Location = new Point(10, 280);
            //pb_crea3.Size = new Size(50, 50);
            //pb_crea3.BackgroundImage = Properties.Resources.musicplayerbig;
            //pb_crea3.BackgroundImageLayout = ImageLayout.Zoom;

            lb_text4.Location = new Point(65, 350);
            lb_text4.Text = "本程序无法作为商业用途，仅为学习用途，程序及代码不允许作为商业用途,如有任何违背被发现,必须追诉法律责任。请保留作者信息珍惜作者劳动成果。 如果如果您想学习本程序，请下载源码。";
            lb_text4.Font = new Font("微软雅黑", 9f);
            lb_text4.Size = new Size(400, 60);
            lb_text4.ForeColor = Color.FromArgb(102, 102, 102);
            lb_text4.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAlias;

            layeredBaseControl1.DUIControls.Add(lb_text5);
            layeredBaseControl1.DUIControls.Add(lb_text4);
            layeredBaseControl1.DUIControls.Add(lb_text3);
            layeredBaseControl1.DUIControls.Add(lb_text2);
            layeredBaseControl1.DUIControls.Add(lb_text1);
            layeredBaseControl1.DUIControls.Add(lb_title);
            layeredBaseControl1.DUIControls.Add(lb_title2);
            layeredBaseControl1.DUIControls.Add(pb_icon);
            layeredBaseControl1.DUIControls.Add(pb_crea1);
            layeredBaseControl1.DUIControls.Add(pb_crea2);
            layeredBaseControl1.DUIControls.Add(lb_text6);
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.layeredBaseControl1 = new LayeredSkin.Controls.LayeredBaseControl();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button2 = new Plugins.Button();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // layeredBaseControl1
            // 
            this.layeredBaseControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layeredBaseControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredBaseControl1.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredBaseControl1.Borders.BottomWidth = 1;
            this.layeredBaseControl1.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredBaseControl1.Borders.LeftWidth = 1;
            this.layeredBaseControl1.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredBaseControl1.Borders.RightWidth = 1;
            this.layeredBaseControl1.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredBaseControl1.Borders.TopWidth = 1;
            this.layeredBaseControl1.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredBaseControl1.Canvas")));
            this.layeredBaseControl1.Location = new System.Drawing.Point(1, 48);
            this.layeredBaseControl1.Name = "layeredBaseControl1";
            this.layeredBaseControl1.Size = new System.Drawing.Size(488, 483);
            this.layeredBaseControl1.TabIndex = 1;
            this.layeredBaseControl1.Text = "layeredBaseControl1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Location = new System.Drawing.Point(49, 487);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(150, 17);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "CSkin论坛 : bbs.cskin.net";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel2.Location = new System.Drawing.Point(49, 465);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(103, 17);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "www.kugou.com";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.HoverImage = global::MusicPlayer.Properties.Resources.button_white_hover;
            this.button2.Location = new System.Drawing.Point(355, 470);
            this.button2.Name = "button2";
            this.button2.NormalImage = global::MusicPlayer.Properties.Resources.button_white_normal;
            this.button2.Palace = new System.Windows.Forms.Padding(5);
            this.button2.PressImage = global::MusicPlayer.Properties.Resources.button_white_click;
            this.button2.Size = new System.Drawing.Size(97, 27);
            this.button2.SizeMode = Plugins.Button.ButtonImageMode.Palace;
            this.button2.TabIndex = 4;
            this.button2.Text = "确定";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel3.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel3.Location = new System.Drawing.Point(49, 445);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(68, 17);
            this.linkLabel3.TabIndex = 5;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "关于制作者";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(490, 532);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.layeredBaseControl1);
            this.Name = "FormAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关于迷你音乐";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.Shown += new System.EventHandler(this.FormAbout_Shown);
            this.Controls.SetChildIndex(this.layeredBaseControl1, 0);
            this.Controls.SetChildIndex(this.linkLabel1, 0);
            this.Controls.SetChildIndex(this.linkLabel2, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.linkLabel3, 0);
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
            System.Diagnostics.Process.Start("http://magicdui.sinacloud.net/about.html");
        }
    }
}
