using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment6_AndreiKazakov
{
    public partial class Form1 : Form
    {
        private const int ROCK = 1;
        private const int PAPER = 2;
        private const int SCISSORS = 3;

        private int computerChoice;
        private string[] choiceNames = {null, "rock", "paper", "scissors"};
        public Form1()
        {
            InitializeComponent();

            InitializeGame();
        }

        private void InitializeGame()
        {
            this.computerChoice = (new Random()).Next(1, 4);
        }

        private void EndGame(int userChoice)
        {
            int winner = DetectWinner(computerChoice, userChoice);

            string winnerStr = winner < 0 ? "Computer wins" : (winner > 0 ? "You win" : "Nobody wins");

            MessageBox.Show(
                $"Computer's choice: {choiceNames[computerChoice]}\nYour choice: {choiceNames[userChoice]}\n{winnerStr}!",
                "Result",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            InitializeGame();
        }

        private int DetectWinner(int a, int b)
        {
            if (a == b) return 0;

            if (a == ROCK && b == SCISSORS) return -1;
            if (a < b) return 1;

            return -DetectWinner(b, a);
        }

        private void RockButton_Click(object sender, EventArgs e)
        {
            EndGame(ROCK);
        }
        private void PaperButton_Click(object sender, EventArgs e)
        {
            EndGame(PAPER);
        }

        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            EndGame(SCISSORS);
        }

    }
}
