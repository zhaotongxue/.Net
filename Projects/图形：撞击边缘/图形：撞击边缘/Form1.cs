using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图形
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // MessageBox.Show(this.Width + "       " + this.Height);
            //MessageBox.Show(Form1.ActiveForm.Width + "        " + Form1.ActiveForm.Height);
            //this.WindowState = FormWindowState.Maximized;
            this.Height = 500;
        }
        Graphics g;
        static Point[] p1, p2;
        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            p1=new Point[] {new Point(12,16),new Point(36,78), new Point(200, 150), new Point(250,150), new Point(300, 200),new Point(250,250),new Point(150,80),new Point(200,250),new Point(200,250),new Point(150,200),new Point(36,78),};
            p2=new Point[] {new Point(12,99),new Point(36,72), new Point(300, 150), new Point(350,100), new Point(450, 100),new Point(500,150),new Point(450,200),new Point(400,300),new Point(350,200),new Point(300,150),new Point(36,72)};
            g.DrawPolygon(new Pen(Color.Black, 3),p1) ;
            g.DrawPolygon(new Pen(Color.Black, 3), p2);
        }
        protected static void move() {
            if (p1 != null&&p2!=null)
            {
                for (int i = 0; i < p1.Length; i++)
                {
                    p1[i].X -= 5;
                    if (p1[i].X <= 5)
                    {
                        p1[i].X = 5;
                    }
                }
                for (int i = 0; i < p2.Length; i++) { 
                    p2[i].Y+=5;
                    if (p2[i].Y >= 450)
                    {
                        p2[i].Y = 450;
                    }
                }
                
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //g.DrawLine(new Pen(Color.Black, 3), new Point(0, 0), new Point(100, 100));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            move();
            if (g != null)
            {
                g.Clear(Color.White);
                g.DrawPolygon(new Pen(Color.Black, 3), p1);
                g.DrawPolygon(new Pen(Color.Black, 3), p2);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) {
                if (timer1.Enabled)
                {
                    timer1.Enabled = false;
                }
                else {
                    timer1.Enabled = true;
                }
            }
        }
    }
}
