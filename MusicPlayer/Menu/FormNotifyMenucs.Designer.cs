namespace MusicPlayer
{
    partial class FormNotifyMenucs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotifyMenucs));
            this.pl_base = new LayeredSkin.Controls.LayeredPanel();
            this.layeredTrackBar1 = new LayeredSkin.Controls.LayeredTrackBar();
            this.pl_base.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_base
            // 
            this.pl_base.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pl_base.Borders.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pl_base.Borders.BottomWidth = 1;
            this.pl_base.Borders.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pl_base.Borders.LeftWidth = 1;
            this.pl_base.Borders.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pl_base.Borders.RightWidth = 1;
            this.pl_base.Borders.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pl_base.Borders.TopWidth = 1;
            this.pl_base.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("pl_base.Canvas")));
            this.pl_base.Controls.Add(this.layeredTrackBar1);
            this.pl_base.Location = new System.Drawing.Point(0, 0);
            this.pl_base.Name = "pl_base";
            this.pl_base.Size = new System.Drawing.Size(215, 278);
            this.pl_base.TabIndex = 0;
            // 
            // layeredTrackBar1
            // 
            this.layeredTrackBar1.AdaptImage = true;
            this.layeredTrackBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredTrackBar1.BackImage = null;
            this.layeredTrackBar1.BackLineColor = System.Drawing.Color.DarkGray;
            this.layeredTrackBar1.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredTrackBar1.Borders.BottomWidth = 1;
            this.layeredTrackBar1.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredTrackBar1.Borders.LeftWidth = 1;
            this.layeredTrackBar1.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredTrackBar1.Borders.RightWidth = 1;
            this.layeredTrackBar1.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredTrackBar1.Borders.TopWidth = 1;
            this.layeredTrackBar1.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredTrackBar1.Canvas")));
            this.layeredTrackBar1.ControlRectangle = new System.Drawing.Rectangle(5, 5, 154, 0);
            this.layeredTrackBar1.LineWidth = 2;
            this.layeredTrackBar1.Location = new System.Drawing.Point(39, 102);
            this.layeredTrackBar1.MouseCanControl = true;
            this.layeredTrackBar1.Name = "layeredTrackBar1";
            this.layeredTrackBar1.Orientation = LayeredSkin.Controls.Orientations.Horizontal;
            this.layeredTrackBar1.PointImage = global::MusicPlayer.Properties.Resources.i_vol_pt_n;
            this.layeredTrackBar1.PointImageHover = global::MusicPlayer.Properties.Resources.i_vol_pt_h;
            this.layeredTrackBar1.PointImagePressed = global::MusicPlayer.Properties.Resources.i_vol_pt_h;
            this.layeredTrackBar1.PointState = LayeredSkin.Controls.ControlStates.Normal;
            this.layeredTrackBar1.Size = new System.Drawing.Size(164, 10);
            this.layeredTrackBar1.SurfaceImage = null;
            this.layeredTrackBar1.SurfaceLineColor = System.Drawing.Color.DimGray;
            this.layeredTrackBar1.TabIndex = 0;
            this.layeredTrackBar1.Text = "layeredTrackBar1";
            this.layeredTrackBar1.Value = 0.5D;
            this.layeredTrackBar1.Click += new System.EventHandler(this.layeredTrackBar1_Click);
            // 
            // FormNotifyMenucs
            // 
            this.AnimationType = LayeredSkin.Forms.AnimationTypes.Custom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(215, 278);
            this.Controls.Add(this.pl_base);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormNotifyMenucs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.FormNotifyMenucs_Deactivate);
            this.Load += new System.EventHandler(this.FormNotifyMenucs_Load);
            this.pl_base.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LayeredSkin.Controls.LayeredPanel pl_base;
        private LayeredSkin.Controls.LayeredTrackBar layeredTrackBar1;
    }
}