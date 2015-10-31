namespace Game0
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MainBoard = new System.Windows.Forms.Panel();
            this.Up = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainBoard
            // 
            this.MainBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainBoard.Location = new System.Drawing.Point(59, 65);
            this.MainBoard.Margin = new System.Windows.Forms.Padding(0);
            this.MainBoard.Name = "MainBoard";
            this.MainBoard.Size = new System.Drawing.Size(600, 600);
            this.MainBoard.TabIndex = 0;
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(810, 144);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(125, 125);
            this.Up.TabIndex = 1;
            this.Up.Text = "U";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(810, 389);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(125, 125);
            this.Down.TabIndex = 2;
            this.Down.Text = "D";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(679, 266);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(125, 125);
            this.Left.TabIndex = 3;
            this.Left.Text = "L";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(941, 266);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(125, 125);
            this.Right.TabIndex = 4;
            this.Right.Text = "R";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(679, 556);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(377, 109);
            this.Start.TabIndex = 5;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1078, 730);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.MainBoard);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.Name = "MainForm";
            this.Text = "2048";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainBoard;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Start;
    }
}

