using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Plumber_Game
{
    public partial class LevelSelect : Form
    {
        Random rnd = new Random();


        public LevelSelect()
        {
            InitializeComponent();
        }

        private void LevelSelect_Load(object sender, EventArgs e)
        {
            Button[] Buttons = { null, buttonLevel1, buttonLevel2, buttonLevel3, buttonLevel4, buttonLevel5, buttonLevel6, buttonLevel7, buttonLevel8, buttonLevel9, buttonLevel10,
            buttonLevel11, buttonLevel12, buttonLevel13, buttonLevel14, buttonLevel15, buttonLevel16, buttonLevel17, buttonLevel18, buttonLevel19, buttonLevel20};

            for(int i = 1; i < Buttons.Length; i++)
            {
                if(i <= Levels.AvailableLevel)
                {
                    Buttons[i].Enabled = true;
                    Buttons[i].Text = i.ToString();
                    Buttons[i].BackgroundImage = null;
                }
            }
                    
            foreach(Level level in Levels.GetCustomLevels())
            {
                comboBoxCustomLevels.Items.Add(level.Name);
            }

        }


        private void LevelSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonLevelRandom_Click(object sender, EventArgs e)
        {
            Levels.CorrectLevelId = 0;
            Levels.ChangeCorrectLevelList(false);
            new PlumberGame().Show();
            this.Hide();
        }

        private void buttonLevel_Click(object sender, EventArgs e)
        {
            Levels.CorrectLevelId = int.Parse(((Button)sender).Text);
            Levels.ChangeCorrectLevelList(false);
            new PlumberGame().Show();
            this.Hide();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void buttonLevelRandom_Click_1(object sender, EventArgs e)
        {
            Levels.CorrectLevelId = rnd.Next(1, Levels.AvailableLevel);
            Levels.ChangeCorrectLevelList(false);
            new PlumberGame().Show();
            this.Hide();
        }

        private void comboBoxCustomLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Levels.CorrectLevelId = comboBoxCustomLevels.SelectedIndex;
            Levels.ChangeCorrectLevelList(true);
            new PlumberGame().Show();
            this.Hide();
        }
    }
}

