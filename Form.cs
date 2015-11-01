using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game0
{
    public partial class MainForm : Form
    {
        public class Square : System.Windows.Forms.PictureBox
        {
            public Graphics gr;
        }
        public Square[,] blocks;
        public Controller controller;
        public MainForm()
        {
            InitializeComponent();
            controller = new Controller(this);

            int panelWidth = this.MainBoard.Width;
            int squareMargin = 10;
            int width = panelWidth / 4;
            int size = 150;
            blocks = new Square[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Square block = new Square();
                    blocks[i, j] = block;
                    block.Left = j * size;
                    block.Top = i * size;
                    block.Width = size;
                    block.Height = size;
                    block.Visible = true;
                    block.BackColor = Color.FromArgb(0, 100, 100, 100);
                    block.Margin = new Padding(squareMargin);
                    MainBoard.Controls.Add(block);
                }
            }
            
        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Up.Enabled = true;
            this.Down.Enabled = true;
            this.Left.Enabled = true;
            this.Right.Enabled = true;
            controller.start();
        }

        private void Up_Click(object sender, EventArgs e)
        {
            controller.shiftUp();
        }

        private void Right_Click(object sender, EventArgs e)
        {
            controller.shiftRight();
        }

        private void Down_Click(object sender, EventArgs e)
        {
            controller.shiftDown();
        }

        private void Left_Click(object sender, EventArgs e)
        {
            controller.shiftLeft();
        }

        private void MainBoard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
