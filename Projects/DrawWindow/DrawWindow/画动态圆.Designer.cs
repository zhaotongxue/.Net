namespace DrawWindow
{
    partial class 画动态圆
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.绘制任意线的窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于这个小程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 48);
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.菜单ToolStripMenuItem.Text = "绘制任意线的窗口";
            this.菜单ToolStripMenuItem.Click += new System.EventHandler(this.菜单ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.关于ToolStripMenuItem.Text = "关于这个小程序";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.绘制任意线的窗口ToolStripMenuItem,
            this.关于这个小程序ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 绘制任意线的窗口ToolStripMenuItem
            // 
            this.绘制任意线的窗口ToolStripMenuItem.Name = "绘制任意线的窗口ToolStripMenuItem";
            this.绘制任意线的窗口ToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.绘制任意线的窗口ToolStripMenuItem.Text = "绘制任意线的窗口";
            this.绘制任意线的窗口ToolStripMenuItem.Click += new System.EventHandler(this.绘制任意线的窗口ToolStripMenuItem_Click);
            // 
            // 关于这个小程序ToolStripMenuItem
            // 
            this.关于这个小程序ToolStripMenuItem.Name = "关于这个小程序ToolStripMenuItem";
            this.关于这个小程序ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.关于这个小程序ToolStripMenuItem.Text = "关于这个小程序";
            this.关于这个小程序ToolStripMenuItem.Click += new System.EventHandler(this.关于这个小程序ToolStripMenuItem_Click);
            // 
            // 画动态圆
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "画动态圆";
            this.Text = "画动态圆";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.画动态圆_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 绘制任意线的窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于这个小程序ToolStripMenuItem;
    }
}