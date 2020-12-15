using System;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
           // Form1.setPlayerNames(p1.Text, p2.Text);
            this.Close();
        }
    }
}