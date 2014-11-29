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
    public partial class DrawForm : Form
    {
        Graphics g;
		private bool canDraw=false;
		private bool isDown = false;
		Point pt1,pt2;
		Pen iPen = new Pen (Color.Black, 1);
        public DrawForm()
        {
            InitializeComponent();
            g=this.CreateGraphics();
            //g.FillRectangle(Brushes.White,new Rectangle(this.Location.X,this.Location.Y,this.Width,this.Height));
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            //g = e.Graphics;
            ////g.DrawLine(new Pen(Color.Black),new Point(100,100),new Point(101,101));
            ////g.DrawLine(new Pen(Color.Black),new Point(0,0),new Point(90,90));
            //pt1 = new Point(100, 100);
            //pt2 = new Point(100, 201);
            //    g.DrawLine(iPen, pt1, pt2);
        }
        
        private void paint() { 
			if (canDraw) {
                Pen i = new Pen(Color.Black);
                g.DrawLine(iPen, pt1, pt2);
               // g.DrawLine(i, new Point(0,0), new Point(100,100));
                //pt2.X = pt2.X+1;
                //pt2.Y = pt2.Y+1;
                //try
                //{
                //    g.DrawLine(iPen, pt1, pt2);
                //}
                //catch (Exception e) {
                //    MessageBox.Show(e.Source);
                //    MessageBox.Show(e.InnerException.ToString());
                //    MessageBox.Show(e.ToString());
                //}
			}
        }
        //鼠标进入
        private void pb1me(object sender, EventArgs e) {
            if (isDown) {
                pt1 = Cursor.Position;
                pt2 = Cursor.Position;
                canDraw = true;
                this.paint();
            }
        }
        //鼠标按下事件
		private void pb1md(object sender,MouseEventArgs e){
			isDown = true;
			canDraw = true;
            pt1 = e.Location;
            pt2 = e.Location;
            paint();
		}
        //鼠标移动事件
		private void pb1mm(object sender,MouseEventArgs e){
			if (isDown) {
				canDraw = true;
                pt1 = e.Location;
                paint();
                pt2 = e.Location;
			}
		}
        //鼠标按起事件
		private void pb1mu(object sender,MouseEventArgs e){
            pt1 = e.Location;
            pt2 = e.Location;
            paint();
			isDown = false;
			canDraw = false;
		}
        //鼠标离开事件
		private void pb1ml(object sender,EventArgs e){
            pt1 = Cursor.Position;
            pt2 = Cursor.Position;
            paint();
            canDraw = false;
		}

        private void pictureBox1_Click(object sender, PaintEventArgs e)
        {

        }

        private void DrawForm_Load(object sender, EventArgs e)
        {

        }
    }
}
