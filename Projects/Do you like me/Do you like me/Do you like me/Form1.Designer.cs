namespace Do_you_like_me
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.like = new System.Windows.Forms.Button();
            this.notLike = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // like
            // 
            this.like.Location = new System.Drawing.Point(320, 261);
            this.like.Name = "like";
            this.like.Size = new System.Drawing.Size(75, 23);
            this.like.TabIndex = 0;
            this.like.Text = "Yes,I do";
            this.like.UseVisualStyleBackColor = true;
            this.like.Click += new System.EventHandler(this.like_Click);
            // 
            // notLike
            // 
            this.notLike.Location = new System.Drawing.Point(671, 261);
            this.notLike.Name = "notLike";
            this.notLike.Size = new System.Drawing.Size(75, 23);
            this.notLike.TabIndex = 1;
            this.notLike.Text = "No,I don\'t";
            this.notLike.UseVisualStyleBackColor = true;
            this.notLike.Click += new System.EventHandler(this.notLike_Click);
            this.notLike.MouseEnter += new System.EventHandler(this.notLike_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(396, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Do you like me????";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(911, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notLike);
            this.Controls.Add(this.like);
            this.MaximumSize = new System.Drawing.Size(927, 544);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button like;
        private System.Windows.Forms.Button notLike;
        private System.Windows.Forms.Label label1;
    }
}

