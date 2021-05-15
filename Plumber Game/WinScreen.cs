﻿using System;
using System.Windows.Forms;

namespace Plumber_Game
{
    public partial class WinScreen : Form
    {
        public WinScreen()
        {
            InitializeComponent();
        }

        private void WinScreen_Load(object sender, EventArgs e)
        {
            labelTimeLeft.Text = $"Оставшаеся время: {PlumberGame.time}c";
            labelAmountOfConections.Text = $"Длина соединеия: {PlumberGame.amountOfConections}т";
            if (Levels.CorrectLevel == Levels.AvailableLevel)
            {

                Properties.Settings.Default.avalibleLevel = ++Levels.AvailableLevel;

                Properties.Settings.Default.Save();
            }



            if (Levels.CorrectLevel == Levels.LevelAmount)
            {
                labelCompGame.Visible = true;
                buttonNextLevel.Enabled = false;
            }

            else if (Levels.CorrectLevel == 0 || Levels.CorrectLevel > 20)
            {
                labelRandomly.Visible = true;
                buttonNextLevel.Enabled = false;
            }
            else
                labelWin.Visible = true;

            if (Levels.CorrectLevel == 0)
                buttonAgain.Visible = true;
            if (Levels.CorrectLevel != 0)
                buttonNextLevel.Visible = true;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void WinScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonNextLevel_Click(object sender, EventArgs e)
        {
            Levels.CorrectLevel++;
            new PlumberGame().Show();
            this.Hide();
        }

        private void buttonLevelSelect_Click(object sender, EventArgs e)
        {
            new LevelSelect().Show();
            this.Hide();
        }

        private void buttonAgain_MouseClick(object sender, MouseEventArgs e)
        {   
            new PlumberGame().Show();
            this.Hide();
        }
    }
}