using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusone;

        void Enable_False()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        void Score()
        {
            if (button1.Text =="X" && button2.Text == "X" && button3.Text == "X"  )
            {
                button1.BackColor = System.Drawing.Color.Black;
                button2.BackColor = System.Drawing.Color.Black;
                button3.BackColor = System.Drawing.Color.Black;

                MessageBox.Show("Player X won the game!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label1.Text);
                label1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = System.Drawing.Color.Black;
                button4.BackColor = System.Drawing.Color.Black;
                button7.BackColor = System.Drawing.Color.Black;

                MessageBox.Show("Player X won the game!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label1.Text);
                label1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X"  )
            {
                button1.BackColor = System.Drawing.Color.Black;
                button5.BackColor = System.Drawing.Color.Black;
                button9.BackColor = System.Drawing.Color.Black;

                MessageBox.Show("Player X won the game!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label1.Text);
                label1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X"  )
            {
                button3.BackColor = System.Drawing.Color.Black;
                button5.BackColor = System.Drawing.Color.Black;
                button7.BackColor = System.Drawing.Color.Black;

                MessageBox.Show("Player X won the game!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label1.Text);
                label1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X"  )
            {
                button2.BackColor = System.Drawing.Color.Black;
                button5.BackColor = System.Drawing.Color.Black;
                button8.BackColor = System.Drawing.Color.Black;

                MessageBox.Show("Player X won the game!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label1.Text);
                label1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X"  )
            {
                button3.BackColor = System.Drawing.Color.Black;
                button6.BackColor = System.Drawing.Color.Black;
                button9.BackColor = System.Drawing.Color.Black;

                MessageBox.Show("Player X won the game!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label1.Text);
                label1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X"  )
            {
                button4.BackColor = System.Drawing.Color.Black;
                button5.BackColor = System.Drawing.Color.Black;
                button6.BackColor = System.Drawing.Color.Black;

                MessageBox.Show("Player X won the game!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label1.Text);
                label1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X"  )
            {
                button4.BackColor = System.Drawing.Color.Black;
                button5.BackColor = System.Drawing.Color.Black;
                button6.BackColor = System.Drawing.Color.Black;

                MessageBox.Show("Player X won the game!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label1.Text);
                label1.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            //===========================================================================================

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"  )
            {
                button1.BackColor = System.Drawing.Color.Black;
                button2.BackColor = System.Drawing.Color.Black;
                button3.BackColor = System.Drawing.Color.Black;

                MessageBox.Show("Player O won the game!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label3.Text);
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O"  )
            {
                button1.BackColor = System.Drawing.Color.Black;
                button4.BackColor = System.Drawing.Color.Black;
                button7.BackColor = System.Drawing.Color.Black;

                MessageBox.Show("Player O won the game!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label3.Text);
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O"  )
            {
                button1.BackColor = System.Drawing.Color.Black;
                button5.BackColor = System.Drawing.Color.Black;
                button9.BackColor = System.Drawing.Color.Black;

                MessageBox.Show("Player O won the game!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label3.Text);
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O"  )
            {
                button3.BackColor = System.Drawing.Color.Black;
                button5.BackColor = System.Drawing.Color.Black;
                button7.BackColor = System.Drawing.Color.Black;

                MessageBox.Show("Player O won the game!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label3.Text);
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O"  )
            {
                button2.BackColor = System.Drawing.Color.Black;
                button5.BackColor = System.Drawing.Color.Black;
                button8.BackColor = System.Drawing.Color.Black;

                MessageBox.Show("Player O won the game!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label3.Text);
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O"  )
            {
                button3.BackColor = System.Drawing.Color.Black;
                button6.BackColor = System.Drawing.Color.Black;
                button9.BackColor = System.Drawing.Color.Black;

                MessageBox.Show("Player O won the game!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label3.Text);
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O"  )
            {
                button4.BackColor = System.Drawing.Color.Black;
                button5.BackColor = System.Drawing.Color.Black;
                button6.BackColor = System.Drawing.Color.Black;

                MessageBox.Show("Player O won the game!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label3.Text);
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O"  )
            {
                button7.BackColor = System.Drawing.Color.Black;
                button8.BackColor = System.Drawing.Color.Black;
                button9.BackColor = System.Drawing.Color.Black;

                MessageBox.Show("Player O won the game!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label3.Text);
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }


        }
            public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button1.Text = "X";
                checker = true;
            }
            else
            {
                button1.Text = "O";
                checker = false;
            }
            Score();
            button1.Enabled = false;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button2.Text = "X";
                checker = true;
            }
            else
            {
                button2.Text = "O";
                checker = false;
            }
            Score();
            button2.Enabled = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button3.Text = "X";
                checker = true;
            }
            else
            {
                button3.Text = "O";
                checker = false;
            }
            Score();
            button3.Enabled = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button4.Text = "X";
                checker = true;
            }
            else
            {
                button4.Text = "O";
                checker = false;
            }
            Score();
            button4.Enabled = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button5.Text = "X";
                checker = true;
            }
            else
            {
                button5.Text = "O";
                checker = false;
            }
            Score();
            button5.Enabled = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button6.Text = "X";
                checker = true;
            }
            else
            {
                button6.Text = "O";
                checker = false;
            }
            Score();
            button6.Enabled = false;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button7.Text = "X";
                checker = true;
            }
            else
            {
                button7.Text = "O";
                checker = false;
            }
            Score();
            button7.Enabled = false;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button8.Text = "X";
                checker = true;
            }
            else
            {
                button8.Text = "O";
                checker = false;
            }
            Score();
            button8.Enabled = false;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button9.Text = "X";
                checker = true;
            }
            else
            {
                button9.Text = "O";
                checker = false;
            }
            Score();
            button9.Enabled = false;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                label1.Text = "0";
                label3.Text = "0";

                button1.BackColor = Color.WhiteSmoke;
                button2.BackColor = Color.WhiteSmoke;
                button3.BackColor = Color.WhiteSmoke;
                button4.BackColor = Color.WhiteSmoke;
                button5.BackColor = Color.WhiteSmoke;
                button6.BackColor = Color.WhiteSmoke;
                button7.BackColor = Color.WhiteSmoke;
                button8.BackColor = Color.WhiteSmoke;
                button9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                button11.Enabled = true;

                button1.BackColor = Color.WhiteSmoke;
                button2.BackColor = Color.WhiteSmoke;
                button3.BackColor = Color.WhiteSmoke;
                button4.BackColor = Color.WhiteSmoke;
                button5.BackColor = Color.WhiteSmoke;
                button6.BackColor = Color.WhiteSmoke;
                button7.BackColor = Color.WhiteSmoke;
                button8.BackColor = Color.WhiteSmoke;
                button9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Do you want to exit?", "TicTacToe",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
