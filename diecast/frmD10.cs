using System;
using System.Windows.Forms;

namespace diecast
{
    public partial class frmD10 : Form
    {
        public frmD10()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            if (tbDiePool.Text != "" && tbDifficulty.Text != "")
            {
                try
                {
                    if (int.Parse(tbDiePool.Text) < 100 && int.Parse(tbDifficulty.Text) < 100)
                    {
                        int DiePool = int.Parse(tbDiePool.Text);
                        int Difficulty = int.Parse(tbDifficulty.Text);
                        int Successes = 0;
                        int RollResult;
                        Random RollValue = new Random();
                        for (int i = 0; i < DiePool; i++)
                        {
                            RollResult = RollValue.Next(10) + 1;
                            if (RollResult == 1)
                            {
                                Successes = Successes - 1;
                            }
                            else if (RollResult == 10)
                            {
                                Successes = Successes + 2;
                            }
                            else if (RollResult >= Difficulty)
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
            this.tbDiePool.Text = "";
            this.tbDifficulty.Text = "";
            this.lblResult.Text = "";
            this.cbReroll.Checked = false;
        }
    }
}
