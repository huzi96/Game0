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
    public class Controller
    {
        public MainForm view;
        public Model model;
        public Controller(MainForm v)
        {
            model = new Model();
            view = v;
        }
        public void draw()
        {
            MainForm.Square[,] blocks = view.blocks;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    MainForm.Square block = blocks[i, j];
                    Block info = model.board[i, j];
                    if (block.gr == null)
                    {
                        block.gr = block.CreateGraphics();
                    }
                    Graphics gr = block.gr;
                    gr.Clear(Color.FromArgb(238,228,218));
                    gr = block.CreateGraphics();
                    gr.DrawString(info.number.ToString(), view.Font
                        , new SolidBrush(Color.FromArgb(119,110,101)), new Point(20, 20));
                    gr.Dispose();
                }
            }
        }
    }
}
