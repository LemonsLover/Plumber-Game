using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plumber_Game
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
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

        private void Menu_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.avalibleLevel > 1)
                buttonClearProgress.Visible = true;
            else
                buttonClearProgress.Visible = false;
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
            if(e.KeyChar == (char)Keys.P)
                if (DialogResult.Yes == MessageBox.Show("Вы хотите заблокировать весь контент ?", "ЧИТЫ !", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
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
            MessageBox.Show("Спасибо Васьковському Виталику (м)оральную поддержку !", "Пасибос !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
