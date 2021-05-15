using System;
using System.Windows.Forms;

namespace Plumber_Game
{
    public partial class WinScreen : Form
    {
        Level correctLevel;
        UnlocksDisplay unlocksDisplay =  new UnlocksDisplay();

        public WinScreen(Level level)
        {
            InitializeComponent();
            this.correctLevel = level;
        }

        private void WinScreen_Load(object sender, EventArgs e)
        {
            if(correctLevel.isOnTime)
                labelTimeLeft.Text = $"Оставшаеся время: {PlumberGame.time}c";

            labelAmountOfConections.Text = $"Длина соединеия: {GameField.amountOfConections}т";
            if (Levels.CorrectLevelId == Levels.AvailableLevel && !correctLevel.IsCastom)
            {
                Properties.Settings.Default.avalibleLevel = ++Levels.AvailableLevel;
                Properties.Settings.Default.Save();

                if (Levels.AvailableLevel % 5 == 0)
                {
                    unlocksDisplay = new UnlocksDisplay(CharacterDisplay.UnlockHat());
                    unlocksDisplay.ShowDialog();
                }
            }



            if (Levels.CorrectLevelId == Levels.LevelAmount && !correctLevel.IsCastom)
            {
                labelCompGame.Visible = true;
                buttonNextLevel.Enabled = false;
            }

            else if (Levels.CorrectLevelId == 0 || Levels.CorrectLevelId > 20 && !correctLevel.IsCastom)
            {
                labelRandomly.Visible = true;
                buttonNextLevel.Enabled = false;
            }
            else
                labelWin.Visible = true;

            if (Levels.CorrectLevelId == 0 || correctLevel.IsCastom)
                buttonAgain.Visible = true;
            if (Levels.CorrectLevelId != 0 && !correctLevel.IsCastom)
                buttonNextLevel.Visible = true;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            new Menu().Show();

            unlocksDisplay.Hide();
            this.Hide();
        }

        private void WinScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonNextLevel_Click(object sender, EventArgs e)
        {
            Levels.CorrectLevelId++;
            new PlumberGame().Show();

            unlocksDisplay.Hide();
            this.Hide();
        }

        private void buttonLevelSelect_Click(object sender, EventArgs e)
        {
            new LevelSelect().Show();

            unlocksDisplay.Hide();
            this.Hide();
        }

        private void buttonAgain_MouseClick(object sender, MouseEventArgs e)
        {   
            new PlumberGame().Show();

            unlocksDisplay.Hide();
            this.Hide();
        }
    }
}
