using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class FormProgress : MyLayeredSkin.FormKg
    {
        public FormProgress()
        {
            InitializeComponent();
        }

        public string File
        {
            get { return layeredLabel1.Text; }
            set { layeredLabel1.Text = value; }
        }

        public double Value
        {
            get { return layeredTrackBar1.Value; }
            set
            {
                layeredTrackBar1.Value = value;
                layeredLabel2.Text = (value * 100).ToString("0") + "%";
            }
        }

        private void FormProgress_Load(object sender, EventArgs e)
        {

        }
    }
}
