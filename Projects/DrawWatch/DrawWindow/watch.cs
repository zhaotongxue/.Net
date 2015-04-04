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
    public partial class watch : Form
    {
        public watch()
        {
            InitializeComponent();
        }
        Graphics g;
        Point centerPoint = new Point();
        private void watch_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            centerPoint = new Point(this.Width / 2, this.Height / 2);
            g = this.CreateGraphics();
        }

        private void watch_Paint(object sender, PaintEventArgs e)
        {
            
        }
        Point secondPoint = new Point();
        Point staticPoint = new Point();
        Point staticStartPoint = new Point();
        Pen secondPen = new Pen(Color.Black,2);
        int second, minute,num;
        Double hour;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Give you a chance to see when is now.....Don't thank me,I'm ...雷锋！
            label1.Text = DateTime.Now.ToString();
            //清了~~~~
            g.Clear(Color.White);
            //画表盘
            Pen drawTimeNum = new Pen(Color.Black, 2);
            secondPen.Width = 2;
            secondPen.Color = Color.Black;
            g.DrawArc(secondPen, this.Width / 2 - 300, this.Height/2- 300, 600, 600, 0,360);
            //可耻地说表盘没画出来。。。。。。
          /*num = 60;
            staticPoint = new Point(this.Width / 2, this.Height / 2);
            for(int i=0;i<60;i++){
                    secondPen.Width=3;
                    if ((i >= 45 && i <= 59))
                    {
                        staticStartPoint.X = (int)(staticPoint.X - 300 * Math.Cos((Math.PI / 180) * (Math.Abs(i * 6 - 270))));
                        staticStartPoint.Y = (int)(staticPoint.Y - 300 * Math.Sin((Math.PI / 180) * (Math.Abs(i * 6 - 270))));
                        staticPoint.X = (int)(staticPoint.X - 280 * Math.Cos((Math.PI / 180) * (Math.Abs(i * 6 - 270))));
                        staticPoint.Y = (int)(staticPoint.Y - 280 * Math.Sin((Math.PI / 180) * (Math.Abs(i * 6 - 270))));
                        g.DrawLine(secondPen, staticStartPoint, staticPoint);
                    }
                    else if (i >= 0 && i <= 15)
                    {
                        staticStartPoint.X = (int)(staticPoint.X + 300 * Math.Cos((Math.PI / 180) * (Math.Abs(90-i * 6))));
                        staticStartPoint.Y = (int)(staticPoint.Y - 300 * Math.Sin((Math.PI / 180) * (Math.Abs(90-i * 6))));
                        staticPoint.X = (int)(staticPoint.X + 280 * Math.Cos((Math.PI / 180) * (Math.Abs(90-i * 6))));
                        staticPoint.Y = (int)(staticPoint.Y - 280 * Math.Sin((Math.PI / 180) * (Math.Abs(90-i * 6))));
                        g.DrawLine(secondPen, staticStartPoint, staticPoint);
                    }
                    else if (i >= 15 && i <= 30)
                    {
                        staticStartPoint.X = (int)(staticPoint.X + 300 * Math.Cos((Math.PI / 180) * (Math.Abs(i * 6 - 90))));
                        staticStartPoint.Y = (int)(staticPoint.Y + 300 * Math.Sin((Math.PI / 180) * (Math.Abs(i * 6 - 90))));
                        staticPoint.X = (int)(staticPoint.X + 280 * Math.Cos((Math.PI / 180) * (Math.Abs(i * 6 - 90))));
                        staticPoint.Y = (int)(staticPoint.Y + 280 * Math.Sin((Math.PI / 180) * (Math.Abs(i * 6 - 90))));
                        g.DrawLine(secondPen, staticStartPoint, staticPoint);
                    }
                    else
                    {
                        staticStartPoint.X = (int)(staticPoint.X - 300 * Math.Cos((Math.PI / 180) * (Math.Abs(i * 6 - 180))));
                        staticStartPoint.Y = (int)(staticPoint.Y + 300 * Math.Sin((Math.PI / 180) * (Math.Abs(i * 6 - 180))));
                        staticPoint.X = (int)(staticPoint.X - 280 * Math.Cos((Math.PI / 180) * (Math.Abs(i * 6 - 180))));
                        staticPoint.Y = (int)(staticPoint.Y + 280 * Math.Sin((Math.PI / 180) * (Math.Abs(i * 6 - 180))));
                        g.DrawLine(secondPen, staticStartPoint, staticPoint);
                    } 
            }*/
            //R为290,每次指针转动一下是6度，换算成弧度制就是（pi/180）*6
            //下下策
           
            secondPen.Color = Color.Black;
            secondPen.Width = 3;
            for (second = 0; second < 60; second++)
            {
                secondPoint.X = this.Width / 2;
                secondPoint.Y = this.Height / 2;
                if ((second > 45 && second <= 59))
                {
                    secondPoint.X = (int)(secondPoint.X - 300 * Math.Cos((Math.PI / 180) * (Math.Abs(second * 6 - 270))));
                    secondPoint.Y = (int)(secondPoint.Y - 300 * Math.Sin((Math.PI / 180) * (Math.Abs(second * 6 - 270))));
                    g.DrawLine(secondPen, centerPoint, secondPoint);
                }
                else if (second >= 0 && second <= 15)
                {
                    secondPoint.X = (int)(secondPoint.X + 300 * Math.Cos((Math.PI / 180) * (Math.Abs(90 - second * 6))));
                    secondPoint.Y = (int)(secondPoint.Y - 300 * Math.Sin((Math.PI / 180) * (Math.Abs(90 - second * 6))));
                    g.DrawLine(secondPen, centerPoint, secondPoint);
                }
                else if (second > 15 && second <= 30)
                {
                    secondPoint.X = (int)(secondPoint.X + 300 * Math.Cos((Math.PI / 180) * (Math.Abs(second * 6 - 90))));
                    secondPoint.Y = (int)(secondPoint.Y + 300 * Math.Sin((Math.PI / 180) * (Math.Abs(second * 6 - 90))));
                    g.DrawLine(secondPen, centerPoint, secondPoint);
                }
                else
                {
                    secondPoint.X = (int)(secondPoint.X - 300 * Math.Sin((Math.PI / 180) * (Math.Abs(second * 6 - 180))));
                    secondPoint.Y = (int)(secondPoint.Y + 300 * Math.Cos((Math.PI / 180) * (Math.Abs(second * 6 - 180))));
                    g.DrawLine(secondPen, centerPoint, secondPoint);
                }
            }
            secondPen.Color = Color.White;
            secondPen.Width = 5;
            for (second = 0; second < 60; second++)
            {
                secondPoint.X = this.Width / 2;
                secondPoint.Y = this.Height / 2;
                if ((second > 45 && second <= 59))
                {
                    secondPoint.X = (int)(secondPoint.X - 285 * Math.Cos((Math.PI / 180) * (Math.Abs(second * 6 - 270))));
                    secondPoint.Y = (int)(secondPoint.Y - 285 * Math.Sin((Math.PI / 180) * (Math.Abs(second * 6 - 270))));
                    g.DrawLine(secondPen, centerPoint, secondPoint);
                }
                else if (second >= 0 && second <= 15)
                {
                    secondPoint.X = (int)(secondPoint.X + 285 * Math.Cos((Math.PI / 180) * (Math.Abs(90 - second * 6))));
                    secondPoint.Y = (int)(secondPoint.Y - 285 * Math.Sin((Math.PI / 180) * (Math.Abs(90 - second * 6))));
                    g.DrawLine(secondPen, centerPoint, secondPoint);
                }
                else if (second > 15 && second <= 30)
                {
                    secondPoint.X = (int)(secondPoint.X + 285 * Math.Cos((Math.PI / 180) * (Math.Abs(second * 6 - 90))));
                    secondPoint.Y = (int)(secondPoint.Y + 285 * Math.Sin((Math.PI / 180) * (Math.Abs(second * 6 - 90))));
                    g.DrawLine(secondPen, centerPoint, secondPoint);
                }
                else
                {
                    secondPoint.X = (int)(secondPoint.X - 285 * Math.Sin((Math.PI / 180) * (Math.Abs(second * 6 - 180))));
                    secondPoint.Y = (int)(secondPoint.Y + 285 * Math.Cos((Math.PI / 180) * (Math.Abs(second * 6 - 180))));
                    g.DrawLine(secondPen, centerPoint, secondPoint);
                }
            }
            //画秒针
             secondPoint.X = this.Width / 2;
             secondPoint.Y = this.Height / 2;
             secondPen.Color = Color.Black;
             secondPen.Width = 1;
            second = DateTime.Now.Second;
            if ((second > 45 && second <= 59))
            {
                secondPoint.X = (int)(secondPoint.X - 290 * Math.Cos((Math.PI / 180) * (Math.Abs(second * 6 - 270))));
                secondPoint.Y = (int)(secondPoint.Y - 290 * Math.Sin((Math.PI / 180) * (Math.Abs(second * 6 - 270))));
                g.DrawLine(secondPen, centerPoint, secondPoint);
            }
            else if (second >= 0 && second <= 15)
            {
                secondPoint.X = (int)(secondPoint.X + 290 * Math.Cos((Math.PI / 180) * (Math.Abs(90 - second * 6))));
                secondPoint.Y = (int)(secondPoint.Y - 290 * Math.Sin((Math.PI / 180) * (Math.Abs(90 - second * 6))));
                g.DrawLine(secondPen, centerPoint, secondPoint);
            }
            else if (second > 15 && second <= 30)
            {
                secondPoint.X = (int)(secondPoint.X + 290 * Math.Cos((Math.PI / 180) * (Math.Abs(second * 6 - 90))));
                secondPoint.Y = (int)(secondPoint.Y + 290 * Math.Sin((Math.PI / 180) * (Math.Abs(second * 6 - 90))));
                g.DrawLine(secondPen, centerPoint, secondPoint);
            }
            else
            {
                secondPoint.X = (int)(secondPoint.X - 290 * Math.Sin((Math.PI / 180) * (Math.Abs(second * 6 - 180))));
                secondPoint.Y = (int)(secondPoint.Y + 290 * Math.Cos((Math.PI / 180) * (Math.Abs(second * 6 - 180))));
                g.DrawLine(secondPen, centerPoint, secondPoint);
            }
            //接下来是分钟了
            minute = DateTime.Now.Minute;
             secondPoint.X = this.Width / 2;
             secondPoint.Y = this.Height / 2;
             secondPen.Color = Color.Blue;
             secondPen.Width = 3;
            if ((minute > 45 && minute <= 59))
            {
                secondPoint.X = (int)(secondPoint.X - 260 * Math.Cos((Math.PI / 180) * (Math.Abs(minute * 6 - 270))));
                secondPoint.Y = (int)(secondPoint.Y - 260 * Math.Sin((Math.PI / 180) * (Math.Abs(minute * 6 - 270))));
                g.DrawLine(secondPen, centerPoint, secondPoint);
            }
            else if (minute >= 0 && minute <= 15)
            {
                secondPoint.X = (int)(secondPoint.X + 260 * Math.Cos((Math.PI / 180) * (Math.Abs(90 - minute * 6))));
                secondPoint.Y = (int)(secondPoint.Y - 260 * Math.Sin((Math.PI / 180) * (Math.Abs(90 - minute * 6))));
                g.DrawLine(secondPen, centerPoint, secondPoint);
            }
            else if (minute > 15 && minute <= 30)
            {
                secondPoint.X = (int)(secondPoint.X + 260 * Math.Cos((Math.PI / 180) * (Math.Abs(minute * 6 - 90))));
                secondPoint.Y = (int)(secondPoint.Y + 260 * Math.Sin((Math.PI / 180) * (Math.Abs(minute * 6 - 90))));
                g.DrawLine(secondPen, centerPoint, secondPoint);
            }
            else
            {
                secondPoint.X = (int)(secondPoint.X - 260 * Math.Sin((Math.PI / 180) * (Math.Abs(minute * 6 - 180))));
                secondPoint.Y = (int)(secondPoint.Y + 260 * Math.Cos((Math.PI / 180) * (Math.Abs(minute * 6 - 180))));
                g.DrawLine(secondPen, centerPoint, secondPoint);
            }
            //接下来是小时
             hour = DateTime.Now.Hour+DateTime.Now.Minute/60;
            if(hour>12){
                hour=hour-12; 
            }
             secondPoint.X = this.Width / 2;
             secondPoint.Y = this.Height / 2;
             secondPen.Color = Color.Red;
             secondPen.Width = 5;
            if (hour >= 9 && hour < 13)
            {
                secondPoint.X = (int)(secondPoint.X - 230 * Math.Cos((Math.PI / 180) * (Math.Abs(hour * 30 - 270))));
                secondPoint.Y = (int)(secondPoint.Y - 230 * Math.Sin((Math.PI / 180) * (Math.Abs(hour * 30 - 270))));
                g.DrawLine(secondPen, centerPoint, secondPoint);
            }
            else if (hour >=0 && hour < 3)
            {
                secondPoint.X = (int)(secondPoint.X + 230 * Math.Cos((Math.PI / 180) * (Math.Abs(90 - hour * 30))));
                secondPoint.Y = (int)(secondPoint.Y - 230 * Math.Sin((Math.PI / 180) * (Math.Abs(90 - hour * 30))));
                g.DrawLine(secondPen, centerPoint, secondPoint);
            }
            else if (hour >= 3 && hour < 6)
            {
                secondPoint.X = (int)(secondPoint.X + 230 * Math.Cos((Math.PI / 180) * (Math.Abs(hour * 30 - 90))));
                secondPoint.Y = (int)(secondPoint.Y + 230 * Math.Sin((Math.PI / 180) * (Math.Abs(hour * 30 - 90))));
                g.DrawLine(secondPen, centerPoint, secondPoint);
            }
            else
            {
                secondPoint.X = (int)(secondPoint.X - 230 * Math.Sin((Math.PI / 180) * (Math.Abs(hour * 30 - 180))));
                secondPoint.Y = (int)(secondPoint.Y + 230 * Math.Cos((Math.PI / 180) * (Math.Abs(hour * 30 - 180))));
                g.DrawLine(secondPen, centerPoint, secondPoint);
            }
        }
    }
}
