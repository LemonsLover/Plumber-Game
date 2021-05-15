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
        }

        private void labelMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спасибо Васьковському Виталику моральную потдержку !", "Пасибос !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
