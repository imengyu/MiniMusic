namespace MusicPlayer
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.pl_base = new LayeredSkin.Controls.LayeredPanel();
            this.SuspendLayout();
            // 
            // pl_base
            // 
            this.pl_base.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pl_base.Borders.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pl_base.Borders.BottomWidth = 1;
            this.pl_base.Borders.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pl_base.Borders.LeftWidth = 1;
            this.pl_base.Borders.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pl_base.Borders.RightWidth = 1;
            this.pl_base.Borders.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pl_base.Borders.TopWidth = 1;
            this.pl_base.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("pl_base.Canvas")));
            this.pl_base.Location = new System.Drawing.Point(0, 0);
            this.pl_base.Name = "pl_base";
            this.pl_base.Size = new System.Drawing.Size(196, 285);
            this.pl_base.TabIndex = 0;
            this.pl_base.Text = "layeredBaseControl1";
            // 
            // FormMainMenu
            // 
            this.AnimationType = LayeredSkin.Forms.AnimationTypes.Custom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(196, 285);
            this.Controls.Add(this.pl_base);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMainMenu";
            this.ShowInTaskbar = false;
            this.Text = "";
            this.Deactivate += new System.EventHandler(this.FormNotifyMenucs_Deactivate);
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LayeredSkin.Controls.LayeredPanel pl_base;
    }
}