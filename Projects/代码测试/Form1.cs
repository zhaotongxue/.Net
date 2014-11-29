using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 代码测试
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Point> p;
        private void Form1_Load(object sender, EventArgs e)
        {
            p.Add(new Point(100, 100));
            p.Add(new Point(200, 100));
            p.Add(new Point(300, 100));
            label1.Text += p.Count()+"\n";
            foreach (Point pp in p) {
                label1.Text += pp.X + "\t" + pp.Y + "\n";
            }
            Point a = new Point(300, 100);
            p[1]=a;
            label1.Text += p[1].X + "\n" + p[1].Y;

        }
    }
}
