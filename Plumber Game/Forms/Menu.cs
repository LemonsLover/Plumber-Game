using System;
using System.Windows.Forms;
using Plumber_Game.Services;

namespace Plumber_Game
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // Initialize translation system
            TranslationManager.Initialize();

            // Update UI with current language
            UpdateUILanguage();

            // Show clear progress button if needed
            if (Properties.Settings.Default.avalibleLevel > 1)
                buttonClearProgress.Visible = true;
            else
                buttonClearProgress.Visible = false;

            // Populate language selector
            PopulateLanguageSelector();
        }

        private void UpdateUILanguage()
        {
            button1.Text = TranslationManager.Get("menu.playGame");
            buttonLevelSelect.Text = TranslationManager.Get("menu.levelSelect");
            buttonLevelCreation.Text = TranslationManager.Get("menu.createLevel");
            buttonExit.Text = TranslationManager.Get("menu.exit");
            buttonClearProgress.Text = TranslationManager.Get("menu.clearProgress");
            labelLanguage.Text = TranslationManager.Get("menu.language") + ":";
            this.Text = TranslationManager.Get("game.title");
        }

        private void PopulateLanguageSelector()
        {
            if (comboBoxLanguage == null)
                return;

            comboBoxLanguage.Items.Clear();
            comboBoxLanguage.Items.Add(TranslationManager.GetLanguageName(GameLanguage.English));
            comboBoxLanguage.Items.Add(TranslationManager.GetLanguageName(GameLanguage.Russian));
            comboBoxLanguage.Items.Add(TranslationManager.GetLanguageName(GameLanguage.Ukrainian));

            comboBoxLanguage.SelectedIndex = (int)TranslationManager.CurrentLanguage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PlumberGame().Show();
            this.Hide();
        }

        private void buttonLevelSelect_Click(object sender, EventArgs e)
        {
            new LevelSelect().Show();
            this.Hide();
        }

        private void buttonLevelCreation_Click(object sender, EventArgs e)
        {
            new LevelCreator().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonClearProgress_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.avalibleHats = 1;
            Properties.Settings.Default.avalibleLevel = 1;
            Properties.Settings.Default.selectedHat = 1;
            Properties.Settings.Default.Save();
            Application.Restart();

            buttonClearProgress.Visible = false;
        }

        private void buttonExit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.P)
                if (DialogResult.Yes == MessageBox.Show("Do you want to unlock all content?", "CHEAT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Properties.Settings.Default.avalibleHats = 4;
                    Properties.Settings.Default.avalibleLevel = 18;
                    Properties.Settings.Default.selectedHat = 1;
                    Properties.Settings.Default.Save();
                    Application.Restart();
                }
        }

        private void labelMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TranslationManager.Get("special.creditsVitalik"), TranslationManager.Get("messages.credits"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLanguage.SelectedIndex >= 0 && comboBoxLanguage.SelectedIndex <= 2)
            {
                GameLanguage selectedLanguage = (GameLanguage)comboBoxLanguage.SelectedIndex;
                TranslationManager.CurrentLanguage = selectedLanguage;
                UpdateUILanguage();
            }
        }
    }
}
