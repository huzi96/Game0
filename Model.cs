using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game0
{
    class GameOver : ApplicationException
    {
        public GameOver(string message):base(message)
        {

        }
    }
    public class Block
    {
        //public int number;
        bool hasValue;
        public Block()
        {
            hasValue = false;
            number = 0;
        }
        //复制构造函数
        public Block(Block old)
        {
            hasValue = old.hasValue;
            number = old.number;
        }
        public static bool operator == (Block b, int n)
        {
            return b.number == n;
        }
        public static bool operator !=(Block b, int n)
        {
            return b.number != n;
        }
        public int number
        {
            set; get;
        }
        public void setNumber(int n)
        {
            this.number = n;
            this.hasValue = true;
        }
    }
    public class Model
    {
        public Block [,]board;
        List<Block> empty;
        public Model()
        {
            empty = new List<Block>();
            board = new Block[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    board[i, j] = new Block();
                    empty.Add(board[i, j]);
                }
            }
        }
        //复制构造函数
        public Model(Model old)
        {
            empty = new List<Block>(old.empty);
            board = new Block[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    board[i, j] = new Block(old.board[i,j]);
                }
            }
        }
        public void addRandomBlock()
        {
            if (empty.Count == 0)
            {
                throw new GameOver("Game over");
            }
            Random rnd = new Random();
            int sel = rnd.Next(0, empty.Count);
            empty[sel].number = rnd.Next(1, 3) * 2;
            empty.Remove(empty[sel]);
        }
        public bool moveLeft()
        {
            bool anyAction = false;
            //对于每一行
            for (int i = 0; i < 4; i++)
            {
                //对于这一行里面的每一个元素
                for (int j = 0; j < 3; j++)
                {
                    //如果这个格子是空
                    if (board[i,j]==0)
                    {
                        //找到它后面的第一个不是空的格子
                        for (int k = j; k < 4; k++)
                        {
                            if (board[i,k]!=0)
                            {
                                //交换这两个格子
                                //因为empty里面存的是具体的格子的引用，所以不会产生问题
                                Block tmp = board[i, j];
                                board[i, j] = board[i, k];
                                board[i, k] = tmp;
                                anyAction = true;
                                break;
                            }
                        }
                    }
                }
                //检查是否可以合并
                //对于前面三个格子中的每个元素
                for (int j = 0; j < 3; j++)
                {
                    //如果它与它下一个的数字相同
                    if (board[i,j].number == board[i,j+1].number&&board[i,j]!=0)
                    {
                        //这个格子的数字*=2
                        board[i, j].number = board[i, j].number * 2;
                        //把后面的格子移上来
                        for (int k = j+1; k < 3; k++)
                        {
                            board[i, k] = board[i, k+1];
                        }
                        //上面的操作事实上把一个引用扔掉了，我们再产生一个空的
                        board[i, 3] = new Block();
                        empty.Add(board[i, 3]);
                    }
                }
            }
            return anyAction;
        }

        public bool moveUp()
        {
            bool anyAction = false;
            //对于每一列
            for (int i = 0; i < 4; i++)
            {
                //对于这一列里面的每一个元素
                for (int j = 0; j < 3; j++)
                {
                    if (board[j, i] == 0)
                    {
                        for (int k = j; k < 4; k++)
                        {
                            if (board[k, i] != 0)
                            {
                                Block tmp = board[j, i];
                                board[j, i] = board[k, i];
                                board[k, i] = tmp;
                                anyAction = true;
                                break;
                            }
                        }
                    }
                }

                for (int j = 0; j < 3; j++)
                {
                    if (board[j, i].number == board[j +1, i].number && board[j, i] != 0)
                    {
                        board[j, i].number = board[j, i].number * 2;
                        for (int k = j + 1; k < 3; k++)
                        {
                            board[k, i] = board[k+1, i];
                        }
                        board[3, i] = new Block();
                        empty.Add(board[3, i]);
                    }
                }
            }
            return anyAction;
        }

        public bool moveRight()
        {
            bool anyAction = false;
            //对于每一行
            for (int i = 0; i < 4; i++)
            {
                //对于这一行里面的每一个元素
                for (int j = 3; j > 0; j--)
                {
                    if (board[i, j] == 0)
                    {
                        for (int k = j; k >= 0; k--)
                        {
                            if (board[i, k] != 0)
                            {
                                Block tmp = board[i, j];
                                board[i, j] = board[i, k];
                                board[i, k] = tmp;
                                anyAction = true;
                                break;
                            }
                        }
                    }
                }

                for (int j = 3; j > 0; j--)
                {
                    if (board[i, j].number == board[i, j - 1].number && board[i, j] != 0)
                    {
                        board[i, j].number = board[i, j].number * 2;
                        for (int k = j - 1; k > 0; k--)
                        {
                            board[i, k] = board[i, k - 1];
                        }
                        board[i, 0] = new Block();
                        empty.Add(board[i, 0]);
                    }
                }
            }
            return anyAction;
        }

        public bool moveDown()
        {
            bool anyAction = false;
            //对于每一列
            for (int i = 0; i < 4; i++)
            {
                //对于这一列里面的每一个元素
                for (int j = 3; j > 0; j--)
                {
                    if (board[j, i] == 0)
                    {
                        for (int k = j; k >= 0; k--)
                        {
                            if (board[k, i] != 0)
                            {
                                Block tmp = board[j, i];
                                board[j, i] = board[k, i];
                                board[k, i] = tmp;
                                anyAction = true;
                                break;
                            }
                        }
                    }
                }

                for (int j = 3; j > 0; j--)
                {
                    if (board[j, i].number == board[j - 1, i].number && board[j, i] != 0)
                    {
                        board[j, i].number = board[j, i].number * 2;
                        for (int k = j - 1; k > 0; k--)
                        {
                            board[k, i] = board[k - 1, i];
                        }
                        board[0, i] = new Block();
                        empty.Add(board[0, i]);
                    }
                }
            }
            return anyAction;
        }
    }
}
