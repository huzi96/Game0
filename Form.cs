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
            Bitmap bm = new Bitmap(150, 150);
            blocks = new Square[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Square block = new Square();
                    blocks[i, j] = block;
                    block.BackColor = Color.FromArgb(100, 100, 100);
                    block.Left = j * size;
                    block.Top = i * size;
                    block.Width = size;
                    block.Height = size;
                    block.Visible = true;
                    block.Margin = new Padding(squareMargin);
                    block.Image = Game0.Properties.Resources._2;
                    MainBoard.Controls.Add(block);
                }
            }


        }

        private void Start_Click(object sender, EventArgs e)
        {
            controller.draw();
        }

        private void Up_Click(object sender, EventArgs e)
        {
            controller.model.moveUp();
            controller.model.addRandomBlock();
            controller.draw();
        }

        private void Right_Click(object sender, EventArgs e)
        {
            controller.model.moveRight();
            controller.model.addRandomBlock();
            controller.draw();
        }

        private void Down_Click(object sender, EventArgs e)
        {
            controller.model.moveDown();
            controller.model.addRandomBlock();
            controller.draw();
        }

        private void Left_Click(object sender, EventArgs e)
        {
            controller.model.moveLeft();
            controller.model.addRandomBlock();
            controller.draw();
        }
    }
}
