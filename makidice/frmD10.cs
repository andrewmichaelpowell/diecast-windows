using System;
using System.Windows.Forms;

namespace makidice
{
    public partial class frmD10 : Form
    {
        public frmD10()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            if (tbDice.Text != "" && tbDifficulty.Text != "")
            {
                try
                {
                    if (int.Parse(tbDice.Text) < 100 && int.Parse(tbDifficulty.Text) < 100)
                    {
                        int Dice = int.Parse(tbDice.Text);
                        int Difficulty = int.Parse(tbDifficulty.Text);
                        int Successes = 0;
                        int Result;
                        Random Roll = new Random();
                        for (int i = 0; i < Dice; i++)
                        {
                            Result = Roll.Next(10) + 1;
                            if (Result == 1)
                            {
                                Successes = Successes - 1;
                            }
                            else if (Result == 10)
                            {
                                Successes = Successes + 2;
                            }
                            else if (Result >= Difficulty)
                            {
                                Successes = Successes + 1;
                            }
                        }
                        if (Successes < -9)
                        {
                            this.lblResult.Text = Successes.ToString();
                        }
                        else if (Successes > -1 && Successes < 10)
                        {
                            this.lblResult.Text = "  " + Successes.ToString();
                        }
                        else
                        {
                            this.lblResult.Text = " " + Successes.ToString();
                        }
                    }
                }
                catch (FormatException)
                {
                }
            }
        }

        private void frmD10_Load(object sender, EventArgs e)
        {
            this.tbDice.Text = "";
            this.tbDifficulty.Text = "";
            this.lblResult.Text = "";
        }
    }
}
