using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace code_test
{
    public partial class Form1 : Form
    {
        List<Point> p=new List<Point>();
        Graphics g,gg;
        Pen i, a;
        public Form1()
        {
            InitializeComponent();
            i=new Pen(Color.Black,3);
            a=new Pen(Color.Blue,3);
            g = this.CreateGraphics();
            gg = this.CreateGraphics();
            g.Clear(Color.White);
            gg.Clear(Color.White);
            /*g.DrawLine(i, new Point(0, 0), new Point(100, 100));
            gg.DrawLine(i, new Point(200, 200), new Point(100, 100));
            System.Threading.Thread.Sleep(1000);
            
           p.Add(new Point(100, 100));
            p.Add(new Point(200, 100));
            p.Add(new Point(300, 100));
            label1.Text += p.Count()+"\n";
            MessageBox.Show(p.Count().ToString());
            foreach (Point pp in p) {
                label1.Text += pp.X + "\t" + pp.Y + "\n";
            }
            Point aa = new Point(300, 100);
            p[1]=aa;
            label1.Text += p[1].X + "\n" + p[1].Y;*/
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.DrawLine(i, new Point(0, 0), new Point(100, 100));
            gg.DrawLine(a, new Point(200, 200), new Point(100, 100));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //g.Clip = new System.Drawing.Region(new Rectangle(0, 0, 100, 100));
            gg.DrawLine(a, new Point(200, 100), new Point(100, 200));
            g.Clear(Color.White);
            gg.Clear(Color.White);
            g.DrawLine(i, new Point(100, 0), new Point(0, 100));
        }
    }
}
