using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace MusicPlayer.Menu
{
    public partial class FormNewList : Form
    {
        public FormNewList()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        string listname = "";
        public string ListName
        {
            get { return listname; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (qqTextBox1.Text != "")
            {
                if (qqTextBox1.Text.Length < 15)
                {
                    listname = qqTextBox1.Text;
                }
                else
                    MessageBox.Show("您写的列表名称太长了。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("列表名称不能为空哦！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void qqTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (qqTextBox1.Text == "" || qqTextBox1.Text.Length > 15)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }
    }
}
