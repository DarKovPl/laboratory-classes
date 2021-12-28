using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeWinFormsApp
{
    public partial class Form1 : Form
    {

        int counter = 0;
        public int theXCounter = 0;
        public int theOCounter = 0;
        bool playerTurn = true;
        
        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = 80;
            timer1.Interval = 200;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerTurn = true;
            counter = 0;
            progressBar1.Value = 0;
            timer1.Start();
            whoseTurn.Text = "X";
            
            foreach (Control i in Controls)
            {
                try
                {
                    Button button = (Button)i;
                    button.Enabled = true;
                    button.Text = "";
                }
                catch
                {
                    Console.WriteLine("Problem with not button's objects.");
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The simple TicTacToe game was created as a project for laboratory classes.", "Created by Dariusz K. Nr. 55560");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttons_clicker(object sender, EventArgs e)
        {
            timer1.Start();
            Button button = (Button)sender;
            button.Text = (playerTurn == true) ? "X" : "O";
            playerTurn = !playerTurn;
            button.Enabled = false;
            counter++;
            CheckWinners();
            progressBar1.Value = 0;
        }

        private void CheckWinners()
        {
            string whoTurn = (playerTurn) ? "X" : "O";
            whoseTurn.Text = whoTurn.ToString();
            
            //  ---
            //  ---
            //  ---
            bool strikethroug = A1.Text == A2.Text && A2.Text == A3.Text && !A1.Enabled
                             || B1.Text == B2.Text && B2.Text == B3.Text && !B1.Enabled
                             || C1.Text == C2.Text && C2.Text == C3.Text && !C1.Enabled
            //  |||
            //  |||
            //  |||
                             || A1.Text == B1.Text && B1.Text == C1.Text && !A1.Enabled
                             || A2.Text == B2.Text && B2.Text == C2.Text && !A2.Enabled
                             || A3.Text == B3.Text && B3.Text == C3.Text && !A3.Enabled
            //  \  /
            //   ||
            //  /  \ 
                             || A1.Text == B2.Text && B2.Text == C3.Text && !A1.Enabled
                             || A3.Text == B2.Text && B2.Text == C1.Text && !C1.Enabled;

            if (strikethroug)
            {
                timer1.Stop();
                
                string whoWins = (playerTurn) ? "O" : "X";
                Wins.Text = (whoWins == "X") ? (++theXCounter).ToString() : theXCounter.ToString();
                Wins2.Text = (whoWins == "O") ? (++theOCounter).ToString() : theOCounter.ToString();
                MessageBox.Show($"Game win: {whoWins}");
                

                foreach (Control i in Controls)
                {
                    try
                    {
                        Button button = (Button)i;
                        button.Enabled = false;
                    }               
                    catch
                    {
                        Console.WriteLine("Problem with not button's objects.");
                    }
                }

            }
            if (counter == 9 && !strikethroug)
            {
                timer1.Stop();
                MessageBox.Show("No one wins!!! There is a draw.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 80)
            {
                progressBar1.Value += 1;
            }
            else if (progressBar1.Value == 80)
            {
                timer1.Stop();
                foreach (Control i in Controls)
                {
                    try
                    {
                        Button button = (Button)i;
                        button.Enabled = false;
                    }
                    catch
                    {
                        Console.WriteLine("Problem with not button's objects.");
                    }
                }


                string whoTurn = (playerTurn) ? "O" : "X";
                MessageBox.Show($"Time out. Player: '{whoTurn}' won the game.");
                
            }
        }
    }
}
