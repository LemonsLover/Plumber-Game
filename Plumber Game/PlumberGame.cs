using Plumber_Game.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Plumber_Game
{
    public partial class PlumberGame : Form
    {
        public static int time;
        public static bool noClip = false;
        public static int amountOfConections = 0;

        CharacterDisplay character = new CharacterDisplay();
        GameField gameField;

        public PlumberGame()
        {
            InitializeComponent();
            gameField = new GameField(tableLayoutPanel1, Levels.CorrectLevel);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            time = 60;
            this.Text = $"Plumber game | Уровень {Levels.CorrectlevelList[Levels.CorrectLevel].Name}";

            noClip = Levels.CorrectlevelList[Levels.CorrectLevel].isNoClip;
            

            if (!noClip)
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
            else
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

            if (Levels.AvailableLevel == 1 && Levels.CorrectLevel == 1 && !Levels.CorrectlevelList[Levels.CorrectLevel].IsCastom)
                MessageBox.Show("В этой игре тебе нужно вжится в роль водопроводчика и соеденить начало и конец водопровода за отведенное время. Удачи !", "Привет !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (Levels.AvailableLevel == 6 && Levels.CorrectLevel == 6 && !Levels.CorrectlevelList[Levels.CorrectLevel].IsCastom)
                MessageBox.Show("Начиная с этого уровня тебе будут иногда попадатся пустые клетки без труб. Удачи !", "Поздравляю !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (Levels.AvailableLevel == 11 && Levels.CorrectLevel == 11 && !Levels.CorrectlevelList[Levels.CorrectLevel].IsCastom)
                MessageBox.Show("Ты прошел ещё 1 ряд ! Теперь некоторые из труб вращать нельзя ! Удачи !", "Поздравляю !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (Levels.AvailableLevel == 16 && Levels.CorrectLevel == 16 && !Levels.CorrectlevelList[Levels.CorrectLevel].IsCastom)
            {
                MessageBox.Show("Ты подошел к финишной прямой, это последний ряд уровней ! Теперь труба переходит в одинаковые цвета по краям!", "Поздравляю !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            timer.Enabled = Levels.CorrectlevelList[Levels.CorrectLevel].isOnTime;
            this.Enabled = true;
            gameField.Update(Levels.CorrectlevelList[Levels.CorrectLevel], Levels.CorrectLevel);

            
            character.Show();
            character.Attach(this.Location);
            character.ChangeCharPosition(1);
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox tile = (PictureBox)sender;


            GameField.RotateTile(ref tile);

            if (gameField.Check(noClip))
            {
                this.Enabled = false;
                timer.Enabled = false;
                character.ChangeCharPosition(2);
                new WinScreen().ShowDialog();
                this.Hide();
                character.Hide();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            this.Text = $"Plumber game | Уровень {Levels.CorrectlevelList[Levels.CorrectLevel].Name} | Осталось времени: {--time}";
            if (time == 0)
            {
                this.Enabled = false;
                timer.Enabled = false;
                var ans = MessageBox.Show("Сыграть еще ?", "Время вышло !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                    Form1_Load(sender, e);
                else
                    this.Close();
            }
        }

        private void PlumberGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Enabled = false;
            new Menu().Show();
            this.Hide();
            character.Hide();
        }

        private void PlumberGame_LocationChanged(object sender, EventArgs e)
        {
            character.Attach(this.Location);
        }
    }
}
