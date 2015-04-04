namespace Greedy_Snake
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.t = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新载入rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.停止sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出qToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于本软件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.得分ToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.label2 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // t
            // 
            this.t.Interval = 200;
            this.t.Tick += new System.EventHandler(this.t_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.得分ToolStripMenuItem,
            this.label2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重新载入rToolStripMenuItem,
            this.暂停pToolStripMenuItem,
            this.toolStripMenuItem1,
            this.停止sToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出qToolStripMenuItem});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.操作ToolStripMenuItem.Text = "操作(&O)";
            // 
            // 重新载入rToolStripMenuItem
            // 
            this.重新载入rToolStripMenuItem.Name = "重新载入rToolStripMenuItem";
            this.重新载入rToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.重新载入rToolStripMenuItem.Text = "重新载入(&R)";
            this.重新载入rToolStripMenuItem.Click += new System.EventHandler(this.重新载入rToolStripMenuItem_Click);
            // 
            // 暂停pToolStripMenuItem
            // 
            this.暂停pToolStripMenuItem.Name = "暂停pToolStripMenuItem";
            this.暂停pToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.暂停pToolStripMenuItem.Text = "暂停(&P)";
            this.暂停pToolStripMenuItem.Click += new System.EventHandler(this.暂停pToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "开始(&S)";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 停止sToolStripMenuItem
            // 
            this.停止sToolStripMenuItem.Name = "停止sToolStripMenuItem";
            this.停止sToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.停止sToolStripMenuItem.Text = "停止(&S)";
            this.停止sToolStripMenuItem.Click += new System.EventHandler(this.停止sToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // 退出qToolStripMenuItem
            // 
            this.退出qToolStripMenuItem.Name = "退出qToolStripMenuItem";
            this.退出qToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出qToolStripMenuItem.Text = "退出(&Q)";
            this.退出qToolStripMenuItem.Click += new System.EventHandler(this.退出qToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于本软件ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.关于ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于本软件ToolStripMenuItem
            // 
            this.关于本软件ToolStripMenuItem.Name = "关于本软件ToolStripMenuItem";
            this.关于本软件ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于本软件ToolStripMenuItem.Text = "关于本软件(&A)";
            this.关于本软件ToolStripMenuItem.Click += new System.EventHandler(this.关于本软件ToolStripMenuItem_Click);
            // 
            // 得分ToolStripMenuItem
            // 
            this.得分ToolStripMenuItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.得分ToolStripMenuItem.Name = "得分ToolStripMenuItem";
            this.得分ToolStripMenuItem.ReadOnly = true;
            this.得分ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.得分ToolStripMenuItem.Text = "得分：";
            this.得分ToolStripMenuItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 562);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer t;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新载入rToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止sToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出qToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于本软件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox 得分ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox label2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;



    }
}

