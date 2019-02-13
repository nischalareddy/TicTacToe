using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void InitializeGame()
        {
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tb4.Text = "";
            tb5.Text = "";
            tb6.Text = "";
            tb7.Text = "";
            tb8.Text = "";
            tb9.Text = "";
            tb1.Enabled = true;
            tb2.Enabled = true;
            tb3.Enabled = true;
            tb4.Enabled = true;
            tb5.Enabled = true;
            tb6.Enabled = true;
            tb7.Enabled = true;
            tb8.Enabled = true;
            tb9.Enabled = true;
            tb1.Select();

        }
        public bool Match()
        {
            if ((tb1.Text == tb2.Text && tb1.Text == tb3.Text && tb1.Text != "") ||
                    (tb1.Text == tb4.Text && tb1.Text == tb7.Text && tb1.Text != "") ||
                    (tb1.Text == tb5.Text && tb1.Text == tb9.Text && tb1.Text != "") ||
                    (tb2.Text == tb5.Text && tb2.Text == tb8.Text && tb2.Text != "") ||
                    (tb3.Text == tb6.Text && tb3.Text == tb9.Text && tb3.Text != "") ||
                    (tb4.Text == tb5.Text && tb4.Text == tb6.Text && tb4.Text != "") ||
                    (tb3.Text == tb5.Text && tb3.Text == tb7.Text && tb3.Text != "") ||
                    (tb7.Text == tb8.Text && tb7.Text == tb9.Text && tb7.Text != ""))
                return true;
            else
                return false;
        }

        public bool Tie()
        {
            if (tb1.Text != "" &&
                tb2.Text != "" &&
                tb3.Text != "" &&
                tb4.Text != "" &&
                tb5.Text != "" &&
                tb6.Text != "" &&
                tb7.Text != "" &&
                tb8.Text != "" &&
                tb9.Text != "")
                return true;
            else
                return false;

        }
        private void tb_TextChanged(object sender, EventArgs e)
        {
            TextBox obj = (TextBox)sender;
            if (obj.Text == "o" || obj.Text == "x")
            {
                obj.Enabled = false;
                
                    if(Match())
                    {
                        MessageBox.Show("Game won by " + obj.Text);
                        InitializeGame();
                    }
                    else if(Tie())
                    {
                        MessageBox.Show("Its a Tie Start a New Game");
                        InitializeGame();
                    }

            }
            else
            {
                obj.Text = "";
            }
        }
    }
}
