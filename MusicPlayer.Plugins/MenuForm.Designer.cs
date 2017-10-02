namespace MusicPlayer.Plugins
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.layeredListBox1 = new LayeredSkin.Controls.LayeredListBox();
            this.SuspendLayout();
            // 
            // layeredListBox1
            // 
            this.layeredListBox1.AutoFocus = false;
            this.layeredListBox1.BackColor = System.Drawing.Color.Transparent;
            this.layeredListBox1.Borders.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.layeredListBox1.Borders.BottomWidth = 1;
            this.layeredListBox1.Borders.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.layeredListBox1.Borders.LeftWidth = 1;
            this.layeredListBox1.Borders.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.layeredListBox1.Borders.RightWidth = 1;
            this.layeredListBox1.Borders.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.layeredListBox1.Borders.TopWidth = 1;
            this.layeredListBox1.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredListBox1.Canvas")));
            this.layeredListBox1.EnabledMouseWheel = true;
            this.layeredListBox1.ItemSize = new System.Drawing.Size(100, 100);
            this.layeredListBox1.ListTop = 0;
            this.layeredListBox1.Location = new System.Drawing.Point(-2, -3);
            this.layeredListBox1.Name = "layeredListBox1";
            this.layeredListBox1.Orientation = LayeredSkin.Controls.ListOrientation.Vertical;
            this.layeredListBox1.RollSize = 20;
            this.layeredListBox1.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.layeredListBox1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.layeredListBox1.ScrollBarHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.layeredListBox1.ScrollBarWidth = 10;
            this.layeredListBox1.ShowScrollBar = true;
            this.layeredListBox1.Size = new System.Drawing.Size(175, 116);
            this.layeredListBox1.SmoothScroll = false;
            this.layeredListBox1.TabIndex = 0;
            this.layeredListBox1.Text = "layeredListBox1";
            this.layeredListBox1.Ulmul = false;
            this.layeredListBox1.Value = 0D;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(173, 114);
            this.Controls.Add(this.layeredListBox1);
            this.Name = "MenuForm";
            this.ShowInTaskbar = false;
            this.Text = "";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LayeredSkin.Controls.LayeredListBox layeredListBox1;
    }
}