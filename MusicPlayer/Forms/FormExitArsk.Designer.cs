namespace MusicPlayer
{
    partial class FormExitArsk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExitArsk));
            this.layeredBaseControl1 = new LayeredSkin.Controls.LayeredBaseControl();
            this.SuspendLayout();
            // 
            // layeredBaseControl1
            // 
            this.layeredBaseControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.layeredBaseControl1.Borders.BottomColor = System.Drawing.Color.Silver;
            this.layeredBaseControl1.Borders.BottomWidth = 1;
            this.layeredBaseControl1.Borders.LeftColor = System.Drawing.Color.Silver;
            this.layeredBaseControl1.Borders.LeftWidth = 1;
            this.layeredBaseControl1.Borders.RightColor = System.Drawing.Color.Silver;
            this.layeredBaseControl1.Borders.RightWidth = 1;
            this.layeredBaseControl1.Borders.TopColor = System.Drawing.Color.Silver;
            this.layeredBaseControl1.Borders.TopWidth = 1;
            this.layeredBaseControl1.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("layeredBaseControl1.Canvas")));
            this.layeredBaseControl1.Location = new System.Drawing.Point(0, 0);
            this.layeredBaseControl1.Name = "layeredBaseControl1";
            this.layeredBaseControl1.Size = new System.Drawing.Size(257, 160);
            this.layeredBaseControl1.TabIndex = 0;
            // 
            // FormExitArsk
            // 
            this.AnimationType = LayeredSkin.Forms.AnimationTypes.Custom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("宋体", 11F);
            this.CaptionHeight = 30;
            this.CaptionOffset = new System.Drawing.Point(8, 7);
            this.CaptionTextRender = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.ClientSize = new System.Drawing.Size(257, 160);
            this.Controls.Add(this.layeredBaseControl1);
            this.DrawIcon = false;
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormExitArsk";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关闭提示";
            this.Load += new System.EventHandler(this.FormExitArsk_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LayeredSkin.Controls.LayeredBaseControl layeredBaseControl1;
    }
}