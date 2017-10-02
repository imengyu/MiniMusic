namespace MusicPlayer.MyLayeredSkin
{
    partial class FormKg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKg));
            this.layeredPanel1 = new LayeredSkin.Controls.LayeredPanel();
            this.sys_btn_close = new LayeredSkin.Controls.LayeredButton();
            this.layeredPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layeredPanel1
            // 
            this.layeredPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layeredPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredPanel1.Borders.BottomColor = System.Drawing.Color.Empty;
            this.layeredPanel1.Borders.BottomWidth = 1;
            this.layeredPanel1.Borders.LeftColor = System.Drawing.Color.Empty;
            this.layeredPanel1.Borders.LeftWidth = 1;
            this.layeredPanel1.Borders.RightColor = System.Drawing.Color.Empty;
            this.layeredPanel1.Borders.RightWidth = 1;
            this.layeredPanel1.Borders.TopColor = System.Drawing.Color.Empty;
            this.layeredPanel1.Borders.TopWidth = 1;
            this.layeredPanel1.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredPanel1.Canvas")));
            this.layeredPanel1.Controls.Add(this.sys_btn_close);
            this.layeredPanel1.Location = new System.Drawing.Point(1, 1);
            this.layeredPanel1.Name = "layeredPanel1";
            this.layeredPanel1.Size = new System.Drawing.Size(619, 40);
            this.layeredPanel1.TabIndex = 0;
            this.layeredPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.layeredPanel1_MouseDown);
            // 
            // sys_btn_close
            // 
            this.sys_btn_close.AdaptImage = true;
            this.sys_btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sys_btn_close.BaseColor = System.Drawing.Color.Wheat;
            this.sys_btn_close.Borders.BottomColor = System.Drawing.Color.Empty;
            this.sys_btn_close.Borders.BottomWidth = 1;
            this.sys_btn_close.Borders.LeftColor = System.Drawing.Color.Empty;
            this.sys_btn_close.Borders.LeftWidth = 1;
            this.sys_btn_close.Borders.RightColor = System.Drawing.Color.Empty;
            this.sys_btn_close.Borders.RightWidth = 1;
            this.sys_btn_close.Borders.TopColor = System.Drawing.Color.Empty;
            this.sys_btn_close.Borders.TopWidth = 1;
            this.sys_btn_close.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("sys_btn_close.Canvas")));
            this.sys_btn_close.ControlState = LayeredSkin.Controls.ControlStates.Normal;
            this.sys_btn_close.HaloColor = System.Drawing.Color.White;
            this.sys_btn_close.HaloSize = 5;
            this.sys_btn_close.HoverImage = global::MusicPlayer.Properties.Resources.btn_close_b_n;
            this.sys_btn_close.IsPureColor = false;
            this.sys_btn_close.Location = new System.Drawing.Point(592, 11);
            this.sys_btn_close.Name = "sys_btn_close";
            this.sys_btn_close.NormalImage = global::MusicPlayer.Properties.Resources.btn_close_b_n;
            this.sys_btn_close.PressedImage = global::MusicPlayer.Properties.Resources.btn_close_b_p;
            this.sys_btn_close.Radius = 10;
            this.sys_btn_close.ShowBorder = true;
            this.sys_btn_close.Size = new System.Drawing.Size(16, 16);
            this.sys_btn_close.TabIndex = 0;
            this.sys_btn_close.TextLocationOffset = new System.Drawing.Point(0, 0);
            this.sys_btn_close.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.sys_btn_close.TextShowMode = LayeredSkin.TextShowModes.Halo;
            this.sys_btn_close.Click += new System.EventHandler(this.sys_btn_close_Click);
            // 
            // FormKg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 383);
            this.Controls.Add(this.layeredPanel1);
            this.Name = "FormKg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormKg_Load);
            this.SizeChanged += new System.EventHandler(this.FormKg_SizeChanged);
            this.layeredPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LayeredSkin.Controls.LayeredPanel layeredPanel1;
        private LayeredSkin.Controls.LayeredButton sys_btn_close;
    }
}