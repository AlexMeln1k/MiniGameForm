using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }

        bool[] items = new bool[9];
        int attempts = 0;

        private void frmGame_Load(object sender, EventArgs e)
        {
            lblPrice.Text = GetPrice(true); ;

            ButtonsControl(false, "?");

            ddlCustomAttempts.SelectedIndex = 2;

        }

        private string GetPrice(bool isPrice)
        {
            if (isPrice)
            {
                return "Gold";
            }
            else
            {
                return "Nothing";
            }
        }

        private void ButtonsControl(bool isEnabled, string item)
        {
            btn1.Enabled = isEnabled;
            btn2.Enabled = isEnabled;
            btn3.Enabled = isEnabled;
            btn4.Enabled = isEnabled;
            btn5.Enabled = isEnabled;
            btn6.Enabled = isEnabled;
            btn7.Enabled = isEnabled;
            btn8.Enabled = isEnabled;
            btn9.Enabled = isEnabled;

            btn1.Text = item;
            btn2.Text = item;
            btn3.Text = item;
            btn4.Text = item;
            btn5.Text = item;
            btn6.Text = item;
            btn7.Text = item;
            btn8.Text = item;
            btn9.Text = item;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            btnNewGame.Enabled = false;
            ddlCustomAttempts.Enabled = false;
            lblImpossibleMode.Enabled = false;
            attempts = Convert.ToInt32(ddlCustomAttempts.SelectedItem);

            FillItemsArray();
            ButtonsControl(true, "?");
        }

        private void FillItemsArray()
        {
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = false;
            }

            int randomIndex = new Random().Next(items.Length);
            items[randomIndex] = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ProcessButtonClick(0);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ProcessButtonClick(1);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ProcessButtonClick(2);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ProcessButtonClick(3);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ProcessButtonClick(4);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ProcessButtonClick(5);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ProcessButtonClick(6);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ProcessButtonClick(7);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ProcessButtonClick(8);
        }

        private void ProcessButtonClick(int index)
        {
            attempts--;

            Button clickedButton = GetButtonByIndex(index);
            clickedButton.Enabled = false;
            clickedButton.Text = GetPrice(items[index]);

            if (items[index])
            {
                MessageBox.Show("You Win");
                btnNewGame.Enabled = true;
                ddlCustomAttempts.Enabled = true;
                lblImpossibleMode.Enabled = true;
                ButtonsControl(false, "?");
                return;
            }

            if (attempts <= 0)
            {
                ButtonsControl(false, "?");

                if (items[index])
                {
                    MessageBox.Show("You Win");
                }
                else
                {
                    MessageBox.Show("You Lose");
                }

                btnNewGame.Enabled = true;
                if (lblImpossibleMode.Checked)
                {
                    ddlCustomAttempts.Enabled = false;
                }
                else
                {
                    ddlCustomAttempts.Enabled = true;
                }
                lblImpossibleMode.Enabled = true;

            }
        }

        private Button GetButtonByIndex(int index)
        {
            switch (index)
            {
                case 0: return btn1;
                case 1: return btn2;
                case 2: return btn3;
                case 3: return btn4;
                case 4: return btn5;
                case 5: return btn6;
                case 6: return btn7;
                case 7: return btn8;
                case 8: return btn9;
                default: return null;
            }
        }

        private void lblImpossibleMode_CheckedChanged(object sender, EventArgs e)
        {
            if (lblImpossibleMode.Checked)
            {
                ddlCustomAttempts.Enabled = false;
            }
            else
            {
                ddlCustomAttempts.Enabled = true;
            }
            ddlCustomAttempts.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
