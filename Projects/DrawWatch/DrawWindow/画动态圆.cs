using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawWindow
{
    public partial class 画动态圆 : Form
    {
        public Graphics g;
        Pen iPen;
        Point[] calcPoints,p;
        Point staticCenter,startLeftPosition,startRightPosition;
        public 画动态圆()
        {
            InitializeComponent();
        }
        private void 画动态圆_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            iPen = new Pen(Color.Blue, 3);
            p = new Point[2];
            calcPoints = new Point[2];
            staticCenter.X = this.Width / 2;
            staticCenter.Y = this.Height / 2;
            startLeftPosition.X = staticCenter.X - 100;
            startLeftPosition.Y = staticCenter.Y;
            startRightPosition.X = this.Width - startLeftPosition.X;
            startRightPosition.Y = this.Height - startLeftPosition.Y;
            g.DrawLine(iPen,new Point(0,0),new Point(100,100));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("aaa", "a");
            g.Clear(Color.White);
            p=calcPositon();
            DrawCircle(p[0], p[1]);
        }
        private Point[] calcPositon() { 
            if (startLeftPosition.X <= staticCenter.X + 100)
            {
                if (startLeftPosition.X <= staticCenter.X)
                {
                    startLeftPosition.X++;
                    startLeftPosition.Y++;
                    startRightPosition.X = this.Width - startLeftPosition.X;
                    startRightPosition.Y = this.Height - startLeftPosition.Y;
                }
                else
                {
                    startLeftPosition.X++;
                    startLeftPosition.Y--;
                    startRightPosition.X = this.Width - startLeftPosition.X;
                    startRightPosition.Y = this.Height - startLeftPosition.Y;
                }
            }
            else {
                startLeftPosition.X = staticCenter.X-100;
                startLeftPosition.Y = staticCenter.Y;
                startRightPosition.X = this.Width - startLeftPosition.X;
                startRightPosition.Y = this.Height - startLeftPosition.Y;
            }
            calcPoints[0]=startLeftPosition;
            calcPoints[1]=startRightPosition;
            return calcPoints;
        }
        private void DrawCircle(Point position1,Point position2) {
            g.DrawLine(iPen, position1, position2);
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("made by 赵业伟，电话：15649026313", "关于");
        }

        private void 菜单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawForm d = new DrawForm();
            d.Show();
        }

        private void 绘制任意线的窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawForm d = new DrawForm();
            d.Show();
        }

        private void 关于这个小程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("made by 赵业伟，电话：15649026313", "关于");
        }
    }
}
