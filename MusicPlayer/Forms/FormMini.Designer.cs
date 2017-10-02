namespace MusicPlayer
{
    partial class FormMini
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMini));
            this.pl_base = new LayeredSkin.Controls.LayeredPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pl_base
            // 
            this.pl_base.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pl_base.Borders.BottomColor = System.Drawing.Color.Empty;
            this.pl_base.Borders.BottomWidth = 1;
            this.pl_base.Borders.LeftColor = System.Drawing.Color.Empty;
            this.pl_base.Borders.LeftWidth = 1;
            this.pl_base.Borders.RightColor = System.Drawing.Color.Empty;
            this.pl_base.Borders.RightWidth = 1;
            this.pl_base.Borders.TopColor = System.Drawing.Color.Empty;
            this.pl_base.Borders.TopWidth = 1;
            this.pl_base.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("pl_base.Canvas")));
            this.pl_base.Location = new System.Drawing.Point(18, 18);
            this.pl_base.Name = "pl_base";
            this.pl_base.Size = new System.Drawing.Size(240, 50);
            this.pl_base.TabIndex = 0;
            this.pl_base.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_base_MouseDown);
            this.pl_base.MouseEnter += new System.EventHandler(this.pl_base_MouseEnter);
            this.pl_base.MouseLeave += new System.EventHandler(this.pl_base_MouseLeave);
            this.pl_base.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pl_base_MouseMove);
            this.pl_base.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pl_base_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormMini
            // 
            this.AnimationType = LayeredSkin.Forms.AnimationTypes.ThreeDTurn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CaptionShowMode = LayeredSkin.TextShowModes.None;
            this.ClientSize = new System.Drawing.Size(276, 87);
            this.Controls.Add(this.pl_base);
            this.DrawIcon = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMini";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "迷你音乐超迷你窗口";
            this.Load += new System.EventHandler(this.FormMini_Load);
            this.Shown += new System.EventHandler(this.FormMini_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private LayeredSkin.Controls.LayeredPanel pl_base;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}