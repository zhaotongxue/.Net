using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_you_like_me
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void notLike_Click(object sender, EventArgs e)
        {
            notLike.Enabled = false;
        }

        private void notLike_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "你就是点不到’No,I don't '";
            Point p = new Point();
            Random r = new Random();
            int x, y;
            do{
                x=r.Next(0, this.Width - notLike.Width);
                y = r.Next(0, this.Height - notLike.Height);
            }
            while((x<this.notLike.Location.X|x>this.notLike.Location.X+notLike.Width)&&(y<this.notLike.Location.Y|y>this.notLike.Location.Y+this.notLike.Height));
            p.X = x;
            p.Y = y;
            notLike.Location = p;
        }

        private void like_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I do ,too\n It's means.......I  like YOU!", "Say");
        }
    }
}
