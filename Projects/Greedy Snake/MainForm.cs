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
    public partial class MainForm : Form
    {
        
        //定义方向
        Keys direction = new Keys();
        //定义要画的格子&蛇
        List<Label> labelList=new List<Label>();
        List<int> snake = new List<int>();
        //食物
        int food;
        //成绩
        int grade = 0;
        //是否失败
        bool fail = false;
        public MainForm()
        {
            InitializeComponent();
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Font f = new Font("宋体", 30);
        private void Form1_Load(object sender, EventArgs e)
        {
            s = this.Size;
            //初始化蛇长
            snake.Add(0);
            snake.Add(1);
            snake.Add(2);
            snake.Add(3);
            snake.Add(4);
            //初始方向
            direction = Keys.Right;
            Point p = new Point(45,45);
            for (int i = 0; i < 16; i++) {
                for (int c = 0; c < 36; c++) {
                    Label b = new Label();
                    //b.ReadOnly = true;
                    b.Font = f;
                    b.Size = new Size(30, 30);
                    b.Location = p;
                    b.BackColor = Color.White;
                    labelList.Add(b);
                    //labelList[i*(this.Width/30-3)+c] = b;
                    this.Controls.Add(b);
                    p.X += 29;
                }
                p.X = 45;
                p.Y += 29;
            }
            //食物
            Random r = new Random();
            food = r.Next(1, labelList.Count);
            t.Enabled = true;
            /*
                labelList[50].BackColor = Color.Black;
                foreach (Button bt in labelList) {
                    this.Controls.Add(bt);
                    label1.Text += bt.Location.ToString() + "\n";
            }
            */
            //table.ColumnCount = 400;
            //table.RowCount = 200;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) {
                if (direction != Keys.Down) {
                    direction = Keys.Up;
                    KeyDownAndTick();
                } 
            }
            else if (e.KeyCode == Keys.Down) {
                if (direction != Keys.Up) {
                    direction = Keys.Down; 
                    KeyDownAndTick();
                } 
            }
            else if (e.KeyCode == Keys.Left) {
                if (direction != Keys.Right) {
                    direction = Keys.Left; 
                    KeyDownAndTick();
                } 
            }
            else if (e.KeyCode == Keys.Right) {
                if (direction != Keys.Left) {
                    direction = Keys.Right; 
                    KeyDownAndTick();
                } 
            }
        }
        //吃到食物时
        protected void ate() {
            bool ate = false;
            if (direction == Keys.Left && snake[snake.Count - 1] - 1 == food) {
                ate = true;
                snake.Add(snake[snake.Count - 1] - 1);
            } 
            else if (direction == Keys.Right && snake[snake.Count - 1] + 1 == food) {
                ate = true;
                snake.Add(snake[snake.Count - 1] + 1);
            } 
            else if (direction == Keys.Up && snake[snake.Count - 1] -36 == food) {
                ate = true;
                snake.Add(snake[snake.Count - 1] - 36);
            } 
            else if (direction == Keys.Down && snake[snake.Count - 1] +36 == food) {
                ate = true;
                snake.Add(snake[snake.Count - 1] +36);
            }
            if (ate) {
                Random r = new Random();
                food=r.Next(1, labelList.Count);
                grade++;
                label2.Text = grade.ToString();
            }
        }
        //吃到自己了……
        public void EatSelf() {
            for (int i = 0; i < snake.Count; i++) {
                for (int j = 0; j < snake.Count; j++) {
                    if (i!=j&&snake[i] == snake[j]) {
                        fail = true; 
                        t.Enabled = false;
                        MessageBox.Show("咬到自己了……\n最终得分：" + grade);
                        return;
                    }
                } 
            } 
        }
        private void t_Tick(object sender, EventArgs e)
        {
            KeyDownAndTick();
        }
        protected void KeyDownAndTick() { 
            EatSelf();
            ate();
            //尾巴丢了
            labelList[snake[0]].BackColor = Color.White ;
                snake.Remove(snake[0]);
            labelList[food].BackColor = Color.Red;

            if (direction == Keys.Left) {
                snake.Add(snake[snake.Count-1] - 1);
                if (snake[snake.Count - 1]%36 ==35||snake[snake.Count-1]<0) {
                    snake[snake.Count - 1] += 36; 
                }
            }
            if (direction == Keys.Right) {
                labelList[snake[0]].BackColor = Color.White ;
                snake.Add(snake[snake.Count-1] + 1);
                if (snake[snake.Count-1]%36 ==0) {
                    snake[snake.Count - 1] -= 36; 
                }
            }
            if (direction == Keys.Up) {
                snake.Add(snake[snake.Count - 1] - 36);
                if (snake[snake.Count - 1] % 36 < 0) {
                    snake[snake.Count - 1] += 16 * 36; 
                }
            }
            if (direction == Keys.Down) {
                snake.Add(snake[snake.Count - 1] + 36);
                if (snake[snake.Count - 1] / 36 >= 16)
                {
                    snake[snake.Count - 1] -= 16 * 36;
                }
            }

            //把蛇画出来
            foreach (int i in snake) {
                labelList[i].BackColor = Color.Black; 
            }
        }

        private void 重新载入rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form1_Load(sender, e);
            //this.Dispose(); 
            MainForm m= new MainForm();
            m.Show();
        }

        private void 暂停pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t.Enabled = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            t.Enabled = true;
        }

        private void 停止sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t.Enabled = false;
        }

        private void 退出qToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于本软件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_GreedySnake a = new About_GreedySnake();
            t.Enabled = false;
            a.ShowDialog();
            t.Enabled = true;

        }

        static Size s = new Size();
        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.Size = s;
        }
    }
}
