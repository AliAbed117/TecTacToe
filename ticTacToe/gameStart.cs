using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticTacToe
{
    public partial class gameStart : Form
    {
        public gameStart()
        {
            InitializeComponent();
        }

        int starter;
        int[,] resultArr = new int[3, 3];

        private void gameStart_Load(object sender, EventArgs e)
        {

            Random rnd = new Random(int.Parse(DateTime.Now.Millisecond.ToString()));
            int starter = rnd.Next(1516161);
            starter = starter % 2;
            label1.Text = "O turn";
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    resultArr[i, j] = rnd.Next();
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (starter == 0)
            {
                pictureBox2.Image = ticTacToe.Properties.Resources.oMark;
                resultArr[0, 1] = 0;
                starter = 1;
                label1.Text = "X turn";
                
            }
            else if (starter == 1)
            {
                pictureBox2.Image = ticTacToe.Properties.Resources.xMark;
                resultArr[0, 0] = 1;
                starter = 0;
                label1.Text = "O Turn";
            }
            pictureBox2.Enabled = false;
            button1.PerformClick();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (starter == 0)
            {
                pictureBox3.Image = ticTacToe.Properties.Resources.oMark;
                resultArr[0, 2] = 0;
                starter = 1;
                label1.Text = "X turn";
            }
            else if (starter == 1)
            {
                pictureBox3.Image = ticTacToe.Properties.Resources.xMark;
                resultArr[0, 2] = 1;
                starter = 0;
                label1.Text = "O Turn";
            }
            pictureBox3.Enabled = false;
            button1.PerformClick();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (starter == 0)
            {
                pictureBox6.Image = ticTacToe.Properties.Resources.oMark;
                resultArr[1, 2] = 0;
                starter = 1;
                label1.Text = "X turn";
            }
            else if (starter == 1)
            {
                pictureBox6.Image = ticTacToe.Properties.Resources.xMark;
                resultArr[1, 2] = 1;
                starter = 0;
                label1.Text = "O Turn";
            }
            pictureBox6.Enabled = false;
            button1.PerformClick();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (starter == 0)
            {
                pictureBox5.Image = ticTacToe.Properties.Resources.oMark;
                resultArr[1, 1] = 0;
                starter = 1;
                label1.Text = "X turn";
            }
            else if (starter == 1)
            {
                pictureBox5.Image = ticTacToe.Properties.Resources.xMark;
                resultArr[1, 1] = 1;
                starter = 0;
                label1.Text = "O Turn";
            }
            pictureBox5.Enabled = false;
            button1.PerformClick();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (starter == 0)
            {
                pictureBox4.Image = ticTacToe.Properties.Resources.oMark;
                resultArr[1, 0] = 0;
                starter = 1;
                label1.Text = "X turn";
            }
            else if (starter == 1)
            {
                pictureBox4.Image = ticTacToe.Properties.Resources.xMark;
                resultArr[1, 0] = 1;
                starter = 0;
                label1.Text = "O Turn";
            }
            pictureBox4.Enabled = false;
            button1.PerformClick();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (starter == 0)
            {
                pictureBox9.Image = ticTacToe.Properties.Resources.oMark;
                resultArr[2, 2] = 0;
                starter = 1;
                label1.Text = "X turn";
            }
            else if (starter == 1)
            {
                pictureBox9.Image = ticTacToe.Properties.Resources.xMark;
                resultArr[2, 2] = 1;
                starter = 0;
                label1.Text = "O Turn";
            }
            pictureBox9.Enabled = false;
            button1.PerformClick();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (starter == 0)
            {
                pictureBox8.Image = ticTacToe.Properties.Resources.oMark;
                resultArr[2, 1] = 0;
                starter = 1;
                label1.Text = "X turn";
            }
            else if (starter == 1)
            {
                pictureBox8.Image = ticTacToe.Properties.Resources.xMark;
                resultArr[2, 1] = 1;
                starter = 0;
                label1.Text = "O Turn";
            }
            pictureBox8.Enabled = false;
            button1.PerformClick();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (starter == 0)
            {
                pictureBox7.Image = ticTacToe.Properties.Resources.oMark;
                resultArr[2, 0] = 0;
                starter = 1;
                label1.Text = "X turn";
            }
            else if (starter == 1)
            {
                pictureBox7.Image = ticTacToe.Properties.Resources.xMark;
                resultArr[2, 0] = 1;
                starter = 0;
                label1.Text = "O Turn";
            }
            pictureBox7.Enabled = false;
            button1.PerformClick();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(starter == 0)
            {
                pictureBox1.Image = ticTacToe.Properties.Resources.oMark;
                resultArr[0, 0] = 0;
                starter = 1;
                label1.Text = "X turn";
            }
            else if(starter == 1)
            {
                pictureBox1.Image = ticTacToe.Properties.Resources.xMark;
                resultArr[0, 0] = 1;
                starter = 0;
                label1.Text = "O Turn";
            }
            pictureBox1.Enabled = false;
            button1.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (resultArr[0, 0] == resultArr[0, 1] && resultArr[0, 1] == resultArr[0, 2] && resultArr[0, 2] == 0)
            {
                MessageBox.Show("O Wins");
            }
            else if (resultArr[1, 0] == resultArr[1, 1] && resultArr[1, 1] == resultArr[1, 2] && resultArr[1, 2] == 0)
            {
                MessageBox.Show("O Wins");
            }
            else if (resultArr[2, 0] == resultArr[2, 1] && resultArr[2, 1] == resultArr[2, 2] && resultArr[2, 2] == 0)
            {
                MessageBox.Show("O Wins");
            }
            else if (resultArr[0, 0] == resultArr[1, 0] && resultArr[1, 0] == resultArr[2, 0] && resultArr[2, 0] == 0)
            {
                MessageBox.Show("O Wins");
            }
            else if (resultArr[0, 1] == resultArr[1, 1] && resultArr[1, 1] == resultArr[2, 1] && resultArr[2, 1] == 0)
            {
                MessageBox.Show("O Wins");
            }
            else if (resultArr[0, 2] == resultArr[1, 2] && resultArr[1, 2] == resultArr[2, 2] && resultArr[2, 2] == 0)
            {
                MessageBox.Show("O Wins");
            }
            else if (resultArr[0, 0] == resultArr[1, 1] && resultArr[1, 1] == resultArr[2, 2] && resultArr[2, 2] == 0)
            {
                MessageBox.Show("O Wins");
            }
            else if (resultArr[0, 2] == resultArr[1, 1] && resultArr[1, 1] == resultArr[2, 0] && resultArr[2, 0] == 0)
            {
                MessageBox.Show("O Wins");
                //Last O win
            }
            else if (resultArr[0, 0] == resultArr[0, 1] && resultArr[0, 1] == resultArr[0, 2] && resultArr[0, 2] == 1)
            {
                MessageBox.Show("X Wins");
            }
            else if (resultArr[1, 0] == resultArr[1, 1] && resultArr[1, 1] == resultArr[1, 2] && resultArr[1, 2] == 1)
            {
                MessageBox.Show("X Wins");
            }
            else if (resultArr[2, 0] == resultArr[2, 1] && resultArr[2, 1] == resultArr[2, 2] && resultArr[2, 2] == 1)
            {
                MessageBox.Show("X Wins");
            }
            else if (resultArr[0, 0] == resultArr[1, 0] && resultArr[1, 0] == resultArr[2, 0] && resultArr[2, 0] == 1)
            {
                MessageBox.Show("X Wins");
            }
            else if (resultArr[0, 1] == resultArr[1, 1] && resultArr[1, 1] == resultArr[2, 1] && resultArr[2, 1] == 1)
            {
                MessageBox.Show("X Wins");
            }
            else if (resultArr[0, 2] == resultArr[1, 2] && resultArr[1, 2] == resultArr[2, 2] && resultArr[2, 2] == 1)
            {
                MessageBox.Show("X Wins");
            }
            else if (resultArr[0, 0] == resultArr[1, 1] && resultArr[1, 1] == resultArr[2, 2] && resultArr[2, 2] == 1)
            {
                MessageBox.Show("X Wins");
            }
            else if (resultArr[0, 2] == resultArr[1, 1] && resultArr[1, 1] == resultArr[2, 0] && resultArr[2, 0] == 1)
            {
                MessageBox.Show("X Wins");
                //Last X win
            }

        }
    }
}
