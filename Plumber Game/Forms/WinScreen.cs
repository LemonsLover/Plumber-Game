using System;
using System.Windows.Forms;
using Plumber_Game.Services;

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
            UpdateUILanguage();
            
            if(correctLevel.IsOnTime)
                labelTimeLeft.Text = string.Format(TranslationManager.Get("winScreen.timeRemaining"), PlumberGame.time);

            labelAmountOfConections.Text = string.Format(TranslationManager.Get("winScreen.connectionLength"), GameField.amountOfConections);
            if (Levels.CorrectLevelId == Levels.AvailableLevel && !correctLevel.IsCustom)
            {
                Properties.Settings.Default.avalibleLevel = ++Levels.AvailableLevel;
                Properties.Settings.Default.Save();

                if (Levels.AvailableLevel % 5 == 0)
                {
                    unlocksDisplay = new UnlocksDisplay(CharacterDisplay.UnlockHat());
                    unlocksDisplay.ShowDialog();
                }
            }



            if (Levels.CorrectLevelId == Levels.LevelAmount && !correctLevel.IsCustom)
            {
                labelCompGame.Visible = true;
                buttonNextLevel.Enabled = false;
            }

            else if (Levels.CorrectLevelId == 0 || Levels.CorrectLevelId > 20 && !correctLevel.IsCustom)
            {
                labelRandomly.Visible = true;
                buttonNextLevel.Enabled = false;
            }
            else
                labelWin.Visible = true;

            if (Levels.CorrectLevelId == 0 || correctLevel.IsCustom)
                buttonAgain.Visible = true;
            if (Levels.CorrectLevelId != 0 && !correctLevel.IsCustom)
                buttonNextLevel.Visible = true;
        }

        private void UpdateUILanguage()
        {
            this.Text = TranslationManager.Get("winScreen.youWon");
            labelWin.Text = TranslationManager.Get("winScreen.youWon");
            labelRandomly.Text = TranslationManager.Get("winScreen.randomLevel");
            labelCompGame.Text = TranslationManager.Get("winScreen.gameCompleted");
            buttonMenu.Text = TranslationManager.Get("winScreen.menu");
            buttonLevelSelect.Text = TranslationManager.Get("winScreen.levelSelect");
            buttonNextLevel.Text = TranslationManager.Get("winScreen.nextLevel");
            buttonAgain.Text = TranslationManager.Get("winScreen.again");
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
