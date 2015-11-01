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
                    gr.DrawString(info.number.ToString(), view.Font
                        , new SolidBrush(Color.FromArgb(119,110,101)), new Point(20, 20));
                }
            }
        }
        public bool checkFail()
        {
            bool checkResult = true;
            Model nextStep = new Model(model);
            //利用短路机制
            checkResult = nextStep.moveDown() || nextStep.moveLeft() ||
                nextStep.moveRight() || nextStep.moveUp();
            return !checkResult;
        }
        public void fail()
        {
            string message = "You fail.";
            string caption = "Fail";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                // Closes the parent form.
                

            }
        }
        public void start()
        {
            model = new Model();
            model.addRandomBlock();
            draw();
        }
        public void shiftLeft()
        {
            //尝试move left 根据返回值判断是否有任何动作
            bool moved = model.moveLeft();
            if (moved)
            {
                model.addRandomBlock();
            }
            draw();
            if (checkFail())
            {
                fail();
            }
        }
        public void shiftUp()
        {
            //尝试move up 根据返回值判断是否有任何动作
            bool moved = model.moveUp();
            if (moved)
            {
                model.addRandomBlock();
            }
            draw();
            if (checkFail())
            {
                fail();
            }
        }
        public void shiftRight()
        {
            //尝试move left 根据返回值判断是否有任何动作
            bool moved = model.moveRight();
            if (moved)
            {
                model.addRandomBlock();
            }
            draw();
            if (checkFail())
            {
                fail();
            }
        }
        public void shiftDown()
        {
            //尝试move left 根据返回值判断是否有任何动作
            bool moved = model.moveDown();
            if (moved)
            {
                model.addRandomBlock();
            }
            draw();
            if (checkFail())
            {
                fail();
            }
        }
    }
}
