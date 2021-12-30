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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {

            bool chosed = (theXPlayer.Checked);
            Form1.pickPlayer(chosed);
            this.Close();
        }
    }
}
