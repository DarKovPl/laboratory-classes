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
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerTurn = true;
            counter = 0;
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
            Button button = (Button)sender;
            button.Text = (playerTurn == true) ? "X" : "O";
            playerTurn = !playerTurn;
            button.Enabled = false;
            counter++;
            CheckWinners();

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
                MessageBox.Show("No one wins!!! There is a draw.");
          
        }

    }
}
