using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace 贪吃蛇
{
    public partial class Form1 : Form
    {
        bool fail,eat;
        int d;//1上2下3左4右
        Point startPoint,endPoint,pp;
        Graphics g,gg;
        //Point[] points;
        List<Point> points;
        Keys k;
        public Form1()
        {
            InitializeComponent();
            points = new List<Point>();
            startPoint = new Point(int.Parse(this.Width.ToString())/2-200, this.Height/2-3);
            endPoint = new Point(int.Parse(this.Width.ToString())/2+100, this.Height/2-3);
            g = this.CreateGraphics();
            gg = this.CreateGraphics();
            timer1.Enabled = true;
            g.Clip = new Region(new Rectangle(0, 0, this.Width,this.Height));
            gg.Clip=new Region(new Rectangle(0,0,this.Width,this.Height));
                Random r = new Random();
                pp = new Point(r.Next(this.Width)/10, r.Next(this.Height)/10);
            drawFood();//画好食物
            points.Add(startPoint);
            points.Add(endPoint);
            k = new Keys();
            k = Keys.Right;
            drawSnake();
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            keyEvent(e);
        }
        public void drawFood() {
            if (eat == true)
            {
                Random r = new Random();
                pp = new Point(r.Next(this.Width - 5), r.Next(this.Height - 5));
                eat = false;
            }
            //gg.DrawArc(new Pen(Color.Blue,1),new Rectangle(new Point(pp.X-3,pp.Y-3),new Size(9,9)),0,360);
            gg.FillPie(Brushes.Blue, new Rectangle(new Point(pp.X - 5, pp.Y - 5), new Size(10, 10)), 0, 360);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            gg.Clear(Color.White);
            drawFood();
            calc();
            drawSnake();
            if (fail == true) {
                timer1.Enabled = false; 
            }
            if((Math.Abs(points[points.Count()-1].X-pp.X)<=5&&Math.Abs(points[points.Count()-1].Y-pp.Y)<=5)){
                eat=true;
                drawFood();
            } 
        }
        public void ifFail() {
            for (int i = 1; i < points.Count(); i++) { 
                 
            } 
        }
        Point temporaryPoint;
        public void calcEndPoint(Point p) { 
                if (points[0].X == points[1].X)
                {
                    if (points[0].Y > points[1].Y)
                    {
                        p = points[0];
                        p.Y -= 10;
                        points[0] = p;
                    }
                    else if (points[0].Y < points[1].Y)
                    {
                        p = points[0];
                        p.Y += 10;
                        points[0] = p;
                    }
                    else
                    {
                        points.Remove(points[0]);
                    }
                }
                else {
                    if (points[0].X > points[1].X)
                    {
                        p = points[0];
                        p.X -= 10;
                        points[0] = p;
                    }
                    else if (points[0].X < points[1].X)
                    {
                        p = points[0];
                        p.X += 10;
                        points[0] = p;
                    }
                    else
                    {
                        points.Remove(points[0]);
                    } 
                }
        }
        public void calc() {
            temporaryPoint = new Point();
            if (k == Keys.Up)
            {
                temporaryPoint=points[points.Count()- 1];
                temporaryPoint.Y-=10;// = new Point[points[points.Count - 1].X, points[points.Count - 1].Y += 10];
                points[points.Count() - 1] = temporaryPoint;
                calcEndPoint(temporaryPoint);
                if (points[points.Count() - 1].Y <= 0) { 
                //temporaryPoint=points[points.Count()- 1];
                //temporaryPoint.Y=this.Height;// = new Point[points[points.Count - 1].X, points[points.Count - 1].Y += 10];
                //points[points.Count() - 1] = temporaryPoint;
                    fail = true;
                }
                //else if (points[points.Count() - 1].Y >= this.Height) { 
                ////temporaryPoint=points[points.Count()- 1];
                ////temporaryPoint.Y=0;// = new Point[points[points.Count - 1].X, points[points.Count - 1].Y += 10];
                ////points[points.Count() - 1] = temporaryPoint;
                //fail = true;
                //}
            }
            else if (k == Keys.Down)
            {
                temporaryPoint=points[points.Count()- 1];
                temporaryPoint.Y+=10;// = new Point[points[points.Count - 1].X, points[points.Count - 1].Y += 10];
                points[points.Count() - 1] = temporaryPoint;
                calcEndPoint(temporaryPoint);
                //   if (points[points.Count() - 1].Y <= 0) { 
                //           fail = true;
                //}
                  if (points[points.Count() - 1].Y >= this.Height)
                   {
                       fail = true;
                   }
            }
            else if (k == Keys.Left)
            {
                temporaryPoint=points[points.Count()- 1];
                temporaryPoint.X-=10;// = new Point[points[points.Count - 1].X, points[points.Count - 1].Y += 10];
                points[points.Count() - 1] = temporaryPoint;
                calcEndPoint(temporaryPoint);
                if (points[points.Count() - 1].X <= 0) {
                    fail = true;
                }
            }
            else if (k == Keys.Right)
            {
                temporaryPoint=points[points.Count()- 1];
                temporaryPoint.X+=10;// = new Point[points[points.Count - 1].X, points[points.Count - 1].Y += 10];
                points[points.Count() - 1] = temporaryPoint;
                calcEndPoint(temporaryPoint);
                if (points[points.Count() - 1].X >= this.Width)
                {
                    fail = true;
                }
            }
        }
        Point c;
        public void keyEvent(KeyEventArgs e) {
            c = new Point();
            if (e.KeyCode == Keys.Up) {
                d = 1;//上
                if (k!= Keys.Up &&k!= Keys.Down) {
                    k = Keys.Up;
                    c = points[points.Count() - 1];
                    points.Add(c);
                }
            }
            else if (e.KeyCode == Keys.Down) {
                d = 2; //下
                if (k!= Keys.Up &&k!= Keys.Down) {
                    k = Keys.Down; 
                    c = points[points.Count() - 1];
                    points.Add(c);
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                d = 3;//左
                if (k != Keys.Left && k != Keys.Right) {
                    k = Keys.Left; 
                    c = points[points.Count() - 1];
                    points.Add(c);
                }
            }
            else if(e.KeyCode==Keys.Right) {
                d = 4;//右
                if (k != Keys.Left && k != Keys.Right) {
                    k = Keys.Right;
                    c = points[points.Count() - 1];
                    points.Add(c);
                }
            }
        }
        Pen ipen = new Pen(Color.Black, 6);
        public void drawSnake() {
            for (int i = 1; i < points.Count();i++ ) {
                 g.DrawLine(ipen,points[i - 1],points[i]);
                }
            }
        }
    }

