using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Plumber_Game.Services;

namespace Plumber_Game
{
    public partial class LevelCreator : Form
    {
        static List<Image> TilesIcons = GameField.TilesIcons;

        private int selectedTileId = 1;

        CharacterDisplay character = new CharacterDisplay();

        public LevelCreator()
        {
            InitializeComponent();
        }

        private void LevelCreator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            character.Hide();
            new Menu().Show();
            this.Hide();
        }

        private void FandeMouseWeel(object sender, MouseEventArgs e)
        {
            selectedTileId += e.Delta / Math.Abs(e.Delta);
            menuSwaper();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {

            selectedTileId += 1;
            menuSwaper();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            selectedTileId -= 1;
            menuSwaper();
        }


        private void buttonClearPlayground_Click(object sender, EventArgs e)
        {
            FillWithEmpty();
        }

        private void buttonSaveLevel_Click(object sender, EventArgs e)
        {
            ValidateLevel();
        }

        private void pictureBoxTile_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                ((PictureBox)sender).Image = TilesIcons[selectedTileId];
            else if (e.Button == MouseButtons.Right)
                ((PictureBox)sender).Image = TilesIcons[11];
        }

        private void buttonFillRandom_Click(object sender, EventArgs e)
        {
            FillEmptyWithRandom();
        }

        private void menuSwaper()
        {
            if (selectedTileId < 0)
                selectedTileId = 17;
            else if (selectedTileId > 17)
                selectedTileId = 0;
            pictureBoxSelectetTile.BackgroundImage = TilesIcons[selectedTileId];

            if (selectedTileId == 0)
                labelTileId.Text = TranslationManager.Get("ui.randomTile");
            else
                labelTileId.Text = string.Format(TranslationManager.Get("ui.tileIdFormat"), selectedTileId);

            if (selectedTileId == 17)
            {
                pictureBoxNextTile.BackgroundImage = TilesIcons[1];
                pictureBoxBeforeTile.BackgroundImage = TilesIcons[selectedTileId - 1];
            }
            else if (selectedTileId == 0)
            {
                pictureBoxNextTile.BackgroundImage = TilesIcons[selectedTileId + 1];
                pictureBoxBeforeTile.BackgroundImage = TilesIcons[17];
            }
            else
            {
                pictureBoxNextTile.BackgroundImage = TilesIcons[selectedTileId + 1];
                pictureBoxBeforeTile.BackgroundImage = TilesIcons[selectedTileId - 1];
            }

        }

        private void FillWithEmpty()
        {
            for (int i = 0; i < tableLayoutPanelPlayground.Controls.Count; i++)
            {

                PictureBox tile = (PictureBox)tableLayoutPanelPlayground.Controls[tableLayoutPanelPlayground.Controls.Count - 1 - i];


                tile.Image = TilesIcons[11];
            }
        }

        private void FillEmptyWithRandom()
        {
            for (int i = 0; i < tableLayoutPanelPlayground.Controls.Count; i++)
            {

                PictureBox tile = (PictureBox)tableLayoutPanelPlayground.Controls[tableLayoutPanelPlayground.Controls.Count - 1 - i];

                if (tile.Image == TilesIcons[11])
                    tile.Image = TilesIcons[0];
            }
        }

        private void ValidateLevel()
        {
            int exitsAmount = 0;
            int[] newLevel = new int[tableLayoutPanelPlayground.Controls.Count];

            for (int i = 0; i < tableLayoutPanelPlayground.Controls.Count; i++)
            {

                PictureBox tile = (PictureBox)tableLayoutPanelPlayground.Controls[tableLayoutPanelPlayground.Controls.Count - 1 - i];

                for (byte j = 0; j < TilesIcons.Count; j++)
                {
                    if (tile.Image == TilesIcons[j])
                        newLevel[i] = j;

                }

                if (tile.Image == TilesIcons[1] || tile.Image == TilesIcons[2] || tile.Image == TilesIcons[3] || tile.Image == TilesIcons[4])
                    exitsAmount++;

            }

            if (exitsAmount < 2)
                MessageBox.Show(TranslationManager.Get("messages.insufficientExits"));
            else if (exitsAmount > 2)
                MessageBox.Show(TranslationManager.Get("messages.tooManyExits"));
            else
            {
                try
                {
                    foreach (Level oldLevel in Levels.CastomLevelsList)
                    {
                        if (oldLevel.Name == textBoxLevelName.Text)
                            throw new Exception(TranslationManager.Get("messages.duplicateLevelName"));
                    }
                    Levels.AddLevel(new Level(textBoxLevelName.Text, newLevel, true, checkBoxNoClip.Checked, checkBoxOnTime.Checked));
                    character.ChangeCharPosition(2);
                    MessageBox.Show(TranslationManager.Get("messages.levelSavedSuccess"), TranslationManager.Get("messages.success"));
                    character.ChangeCharPosition(3);

                    textBoxLevelName.Text = string.Format(TranslationManager.Get("ui.customLevelFormat"), Levels.CastomLevelsList.Count);
                    FillWithEmpty();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, TranslationManager.Get("messages.error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void LevelCreator_Load(object sender, EventArgs e)
        {
            UpdateUILanguage();
            
            textBoxLevelName.Text = string.Format(TranslationManager.Get("ui.customLevelFormat"), Levels.CastomLevelsList.Count);

            this.MouseWheel += FandeMouseWeel;
            FillWithEmpty();
            pictureBoxNextTile.BackgroundImage = TilesIcons[selectedTileId + 1];
            pictureBoxSelectetTile.BackgroundImage = TilesIcons[selectedTileId];
            pictureBoxBeforeTile.BackgroundImage = TilesIcons[17];

            character.Show();
            character.Attach(this.Location, this.Width);
            character.ChangeCharPosition(3);
        }

        private void UpdateUILanguage()
        {
            buttonMenu.Text = TranslationManager.Get("levelCreator.menu");
            buttonFillRandom.Text = TranslationManager.Get("levelCreator.fillRandomBtn");
            buttonSaveLevel.Text = TranslationManager.Get("levelCreator.saveLevelBtn");
            buttonClearPlayground.Text = TranslationManager.Get("levelCreator.clearField");
            label7.Text = TranslationManager.Get("levelCreator.levelNameLabel");
            checkBoxNoClip.Text = TranslationManager.Get("levelCreator.noClipCheck");
            checkBoxOnTime.Text = TranslationManager.Get("levelCreator.timedCheck");
            labelCaption1.Text = TranslationManager.Get("levelCreator.instruction1");
            labelCaption2.Text = TranslationManager.Get("levelCreator.instruction2");
            labelCaption3.Text = TranslationManager.Get("levelCreator.instruction3");
            labelCaption4.Text = TranslationManager.Get("levelCreator.instruction4");
            label3.Text = TranslationManager.Get("levelCreator.note1");
            label4.Text = TranslationManager.Get("levelCreator.note2");
            label6.Text = TranslationManager.Get("levelCreator.note3");
        }

        private void LevelCreator_LocationChanged(object sender, EventArgs e)
        {
            character.Attach(this.Location, this.Width);
        }

        private void checkBoxNoClip_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNoClip.Checked)
            {
                pictureBoxUi1.Visible = true;
                pictureBoxUi2.Visible = true;
                pictureBoxUi3.Visible = true;
                pictureBoxUi4.Visible = true;
                pictureBoxUi5.Visible = true;
                pictureBoxUi6.Visible = true;
                pictureBoxUi7.Visible = true;
                pictureBoxUi8.Visible = true;
                pictureBoxUi9.Visible = true;
                pictureBoxUi10.Visible = true;
            }
            else
            {
                pictureBoxUi1.Visible = false;
                pictureBoxUi2.Visible = false;
                pictureBoxUi3.Visible = false;
                pictureBoxUi4.Visible = false;
                pictureBoxUi5.Visible = false;
                pictureBoxUi6.Visible = false;
                pictureBoxUi7.Visible = false;
                pictureBoxUi8.Visible = false;
                pictureBoxUi9.Visible = false;
                pictureBoxUi10.Visible = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TranslationManager.Get("special.creditsVlad"), TranslationManager.Get("messages.credits"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
