using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greedy_Snake
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                MainForm.SetName((int)numericUpDown1.Value, (int)numericUpDown2.Value, textBox1.Text.ToString());
                MessageBox.Show("欢迎你！" + textBox1.Text);
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        MainForm.setSpeed(300);
                        break;
                    case 1:
                        MainForm.setSpeed(200);
                        break;
                    case 2:
                        MainForm.setSpeed(100);
                        break;
                    case 3:
                        MainForm.setSpeed(50);
                        break;
                }
                this.Hide();
                MainForm m = new MainForm();
                m.Show();
            }
            else {
                label4.Visible = true;
                label4.ForeColor = Color.Red;
            }
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            this.Show();
            comboBox1.SelectedIndex = 0;
        }
        private void ConfigForm_Shown(object sender, EventArgs e)
        {
           textBox1.Focus();
        }
    }
}
