namespace MusicPlayer
{
    partial class FormProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProgress));
            this.layeredTrackBar1 = new LayeredSkin.Controls.LayeredTrackBar();
            this.layeredLabel1 = new LayeredSkin.Controls.LayeredLabel();
            this.layeredLabel2 = new LayeredSkin.Controls.LayeredLabel();
            this.SuspendLayout();
            // 
            // layeredTrackBar1
            // 
            this.layeredTrackBar1.AdaptImage = true;
            this.layeredTrackBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredTrackBar1.BackImage = null;
            this.layeredTrackBar1.BackLineColor = System.Drawing.Color.Gray;
            this.layeredTrackBar1.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredTrackBar1.Borders.BottomWidth = 1;
            this.layeredTrackBar1.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredTrackBar1.Borders.LeftWidth = 1;
            this.layeredTrackBar1.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredTrackBar1.Borders.RightWidth = 1;
            this.layeredTrackBar1.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredTrackBar1.Borders.TopWidth = 1;
            this.layeredTrackBar1.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredTrackBar1.Canvas")));
            this.layeredTrackBar1.ControlRectangle = new System.Drawing.Rectangle(5, 5, 344, 6);
            this.layeredTrackBar1.LineWidth = 4;
            this.layeredTrackBar1.Location = new System.Drawing.Point(12, 74);
            this.layeredTrackBar1.MouseCanControl = true;
            this.layeredTrackBar1.Name = "layeredTrackBar1";
            this.layeredTrackBar1.Orientation = LayeredSkin.Controls.Orientations.Horizontal;
            this.layeredTrackBar1.PointImage = null;
            this.layeredTrackBar1.PointImageHover = null;
            this.layeredTrackBar1.PointImagePressed = null;
            this.layeredTrackBar1.PointState = LayeredSkin.Controls.ControlStates.Normal;
            this.layeredTrackBar1.Size = new System.Drawing.Size(354, 16);
            this.layeredTrackBar1.SurfaceImage = null;
            this.layeredTrackBar1.SurfaceLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.layeredTrackBar1.TabIndex = 1;
            this.layeredTrackBar1.Text = "layeredTrackBar1";
            this.layeredTrackBar1.Value = 0.5D;
            // 
            // layeredLabel1
            // 
            this.layeredLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredLabel1.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredLabel1.Borders.BottomWidth = 1;
            this.layeredLabel1.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredLabel1.Borders.LeftWidth = 1;
            this.layeredLabel1.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredLabel1.Borders.RightWidth = 1;
            this.layeredLabel1.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredLabel1.Borders.TopWidth = 1;
            this.layeredLabel1.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredLabel1.Canvas")));
            this.layeredLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.layeredLabel1.HaloSize = 5;
            this.layeredLabel1.Location = new System.Drawing.Point(12, 51);
            this.layeredLabel1.Name = "layeredLabel1";
            this.layeredLabel1.Size = new System.Drawing.Size(316, 17);
            this.layeredLabel1.TabIndex = 2;
            this.layeredLabel1.Text = "正在搜索项目...";
            this.layeredLabel1.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.layeredLabel1.TextShowMode = LayeredSkin.TextShowModes.Ordinary;
            // 
            // layeredLabel2
            // 
            this.layeredLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredLabel2.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredLabel2.Borders.BottomWidth = 1;
            this.layeredLabel2.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredLabel2.Borders.LeftWidth = 1;
            this.layeredLabel2.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredLabel2.Borders.RightWidth = 1;
            this.layeredLabel2.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredLabel2.Borders.TopWidth = 1;
            this.layeredLabel2.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredLabel2.Canvas")));
            this.layeredLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.layeredLabel2.HaloSize = 5;
            this.layeredLabel2.Location = new System.Drawing.Point(326, 51);
            this.layeredLabel2.Name = "layeredLabel2";
            this.layeredLabel2.Size = new System.Drawing.Size(40, 17);
            this.layeredLabel2.TabIndex = 3;
            this.layeredLabel2.Text = "0%";
            this.layeredLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.layeredLabel2.TextRenderMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.layeredLabel2.TextShowMode = LayeredSkin.TextShowModes.Ordinary;
            // 
            // FormProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 102);
            this.Controls.Add(this.layeredLabel2);
            this.Controls.Add(this.layeredLabel1);
            this.Controls.Add(this.layeredTrackBar1);
            this.Name = "FormProgress";
            this.ShowInTaskbar = false;
            this.Text = "正在添加音乐，请稍后...";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormProgress_Load);
            this.Controls.SetChildIndex(this.layeredTrackBar1, 0);
            this.Controls.SetChildIndex(this.layeredLabel1, 0);
            this.Controls.SetChildIndex(this.layeredLabel2, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private LayeredSkin.Controls.LayeredTrackBar layeredTrackBar1;
        private LayeredSkin.Controls.LayeredLabel layeredLabel1;
        private LayeredSkin.Controls.LayeredLabel layeredLabel2;
    }
}