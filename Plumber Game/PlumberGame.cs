using Plumber_Game.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Plumber_Game
{
    public partial class PlumberGame : Form
    {
        Random rnd = new Random();
        public static int time;
        public static bool noClip = false;
        public static int amountOfConections = 0;

        public static List<Image> TilesIcons = new List<Image>()
        {
            Resources.randomTile,        //0
            Resources.Start_end_left,   //1
            Resources.Start_end_up,     //2
            Resources.Start_end_right,  //3
            Resources.Start_end_down,   //4
            Resources.Knee_left_up,     //5
            Resources.Knee_up_right,    //6
            Resources.Knee_right_down,  //7
            Resources.Knee_down_left,   //8
            Resources.Tube_horizontal,  //9
            Resources.Tube_vertical,    //10
            Resources.emptyTile,        //11
            Resources.Knee_left_up_disabled,     //12
            Resources.Knee_up_right_disabled,    //13
            Resources.Knee_right_down_disabled,  //14
            Resources.Knee_down_left_disabled,   //15
            Resources.Tube_horizontal_disabled,  //16
            Resources.Tube_vertical_disabled    //17
        };

        
        public static int AvailableLevel = Properties.Settings.Default.avalibleLevel;
        public static int ThisLevel = 1;
        public static int LevelAmount = Levels.LevelsList.Count - 1;

        Character character = new Character();

        public PlumberGame()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            time = 60;
            labelThisLevel.Text = $"Уровень {Levels.LevelsList[ThisLevel].Name}";
            this.Text = $"Plumber game | Уровень {Levels.LevelsList[ThisLevel].Name}";


            if (ThisLevel == 0)
                buttonGenerate.Visible = true;
            else
                buttonGenerate.Visible = false;

            
            if (ThisLevel == 0)
            {
                labelThisLevel.Text = "Уровень: рандомный";
                this.Text = $"Plumber game | Уровень: рандомный";
                noClip = true;
            }
            else if (ThisLevel <= 15)
                noClip = false;
            else if (ThisLevel > 15)
            {
                noClip = true;
            }

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

            if (AvailableLevel == 1 && ThisLevel == 1)
                MessageBox.Show("В этой игре тебе нужно вжится в роль водопроводчика и соеденить начало и конец водопровода за отведенное время. Удачи !", "Привет !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (AvailableLevel == 6 && ThisLevel == 6)
                MessageBox.Show("Начиная с этого уровня тебе будут иногда попадатся пустые клетки без труб. Удачи !", "Поздравляю !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (AvailableLevel == 11 && ThisLevel == 11)
                MessageBox.Show("Ты прошел ещё 1 ряд ! Теперь некоторые из труб вращать нельзя ! Удачи !", "Поздравляю !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (AvailableLevel == 16 && ThisLevel == 16)
            {
                MessageBox.Show("Ты подошел к финишной прямой, это последний ряд уровней ! Теперь труба переходит в одинаковые цвета по краям!", "Поздравляю !",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            timer.Enabled = true;
            this.Enabled = true;
            Update(Levels.LevelsList[ThisLevel], ThisLevel);

            
            character.Show();
            character.Attach(this.Location);
            character.ChangeCharPosition(1);
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox tile = (PictureBox)sender;


            TileRotation(ref tile);

            if (ThisLevel == 0)
            {
                labelThisLevel.Text = "Уровень: рандомный";
                this.Text = $"Plumber game | Уровень: рандомный";
                noClip = true;
            }

            if (Check(noClip))
            {
                this.Enabled = false;
                timer.Enabled = false;
                character.ChangeCharPosition(2);
                new WinScreen().ShowDialog();
                this.Hide();
                character.Hide();
            }
        }

        private void Update(Level Level, int thisLevel)
        {
            PictureBox tile;
            do
            {
                for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
                {

                    tile = (PictureBox)tableLayoutPanel1.Controls[tableLayoutPanel1.Controls.Count - 1 - i];

                    tile.Image = TilesIcons[Level.LevelArr[i]];
                    if (Level.LevelArr[i] == 0)
                    {
                        if (thisLevel == 0 || thisLevel > 15)
                        {
                            int rand = rnd.Next(0, 101);
                            if (rand >= 0 && rand <= 80)
                                tile.Image = TilesIcons[rnd.Next(5, 11)];
                            else if (rand >= 80 && rand < 90)
                                tile.Image = TilesIcons[rnd.Next(12, 18)];
                            else
                                tile.Image = TilesIcons[11];
                        }

                        else if (thisLevel <= 5)
                            tile.Image = TilesIcons[rnd.Next(5, 11)];

                        else if (thisLevel > 5 && thisLevel <= 10)
                        {
                            int rand = rnd.Next(0, 101);
                            if (rand <= 90)
                                tile.Image = TilesIcons[rnd.Next(5, 11)];
                            else
                                tile.Image = TilesIcons[11];
                        }
                        else if (thisLevel > 10 && thisLevel <= 15)
                        {
                            int rand = rnd.Next(0, 101);
                            if (rand >= 0 && rand <= 80)
                                tile.Image = TilesIcons[rnd.Next(5, 11)];
                            else if (rand >= 80 && rand < 95)
                                tile.Image = TilesIcons[rnd.Next(12, 18)];
                            else
                                tile.Image = TilesIcons[11];
                        }
                    }
                }
        } while (!Check(noClip) && ThisLevel == 0);
            RollTilesGently();
        }

        private bool Check(bool noClip = false)
        {
            int previousI = 0;
            bool startIsFound = false, firstTileIsStart = true;
            amountOfConections = 0;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                int tileI = tableLayoutPanel1.Controls.Count - 1 - i;
                PictureBox tile = (PictureBox)tableLayoutPanel1.Controls[tileI];
                Image nextRightTile = TilesIcons[0], nextDownTile = TilesIcons[0], nextUpTile = TilesIcons[0], nextLeftTile = TilesIcons[0], lastTile = TilesIcons[0],
                    firstTile = TilesIcons[0];

                if (i != tableLayoutPanel1.Controls.Count - 1)
                    nextRightTile = ((PictureBox)tableLayoutPanel1.Controls[tileI - 1]).Image;
                if (i != 0)
                    nextLeftTile = ((PictureBox)tableLayoutPanel1.Controls[tileI + 1]).Image;
                if (i < tableLayoutPanel1.Controls.Count - 5)
                    nextDownTile = ((PictureBox)tableLayoutPanel1.Controls[tileI - 5]).Image;
                if (i >= 5)
                    nextUpTile = ((PictureBox)tableLayoutPanel1.Controls[tileI + 5]).Image;

                lastTile = ((PictureBox)tableLayoutPanel1.Controls[0]).Image;
                firstTile = ((PictureBox)tableLayoutPanel1.Controls[tableLayoutPanel1.Controls.Count - 1]).Image;
                int lastTileId = tableLayoutPanel1.Controls.Count - 1;
                int firstTileId = 0;
                bool canJumpLast;
                bool canJumpFirst;
                bool canJumpLeft;
                bool canJumpRight;
                bool canJumpUp = (nextUpTile == TilesIcons[7] || nextUpTile == TilesIcons[8] || nextUpTile == TilesIcons[10] ||
                    nextUpTile == TilesIcons[14] || nextUpTile == TilesIcons[15] || nextUpTile == TilesIcons[17]);
                bool canJumpDown = (nextDownTile == TilesIcons[6] || nextDownTile == TilesIcons[5] || nextDownTile == TilesIcons[10] ||
                    nextDownTile == TilesIcons[13] || nextDownTile == TilesIcons[12] || nextDownTile == TilesIcons[17]);


                if (!noClip)
                {
                    canJumpLeft = (i % 5 != 0) && (nextLeftTile == TilesIcons[9] || nextLeftTile == TilesIcons[7] || nextLeftTile == TilesIcons[6] ||
                        nextLeftTile == TilesIcons[16] || nextLeftTile == TilesIcons[14] || nextLeftTile == TilesIcons[13]);
                    canJumpRight = (i + 1) % 5 != 0 && (nextRightTile == TilesIcons[5] || nextRightTile == TilesIcons[8] || nextRightTile == TilesIcons[9] ||
                        nextRightTile == TilesIcons[12] || nextRightTile == TilesIcons[15] || nextRightTile == TilesIcons[16]);
                    canJumpLast = false;
                    canJumpFirst = false;
                }
                else
                {
                    canJumpLeft = (nextLeftTile == TilesIcons[9] || nextLeftTile == TilesIcons[7] || nextLeftTile == TilesIcons[6] ||
                        nextLeftTile == TilesIcons[16] || nextLeftTile == TilesIcons[14] || nextLeftTile == TilesIcons[13]);
                    canJumpRight = (nextRightTile == TilesIcons[5] || nextRightTile == TilesIcons[8] || nextRightTile == TilesIcons[9] ||
                        nextRightTile == TilesIcons[12] || nextRightTile == TilesIcons[15] || nextRightTile == TilesIcons[16]);
                    canJumpLast = (lastTile == TilesIcons[6] || lastTile == TilesIcons[7] || lastTile == TilesIcons[9] ||
                        lastTile == TilesIcons[13] || lastTile == TilesIcons[14] || lastTile == TilesIcons[16]);
                    canJumpFirst = (firstTile == TilesIcons[5] || firstTile == TilesIcons[8] || firstTile == TilesIcons[9] ||
                        firstTile == TilesIcons[12] || firstTile == TilesIcons[15] || firstTile == TilesIcons[16]);
                }

                //find start
                if (!startIsFound && tile.Image != TilesIcons[1] && tile.Image != TilesIcons[2] && tile.Image != TilesIcons[3] && tile.Image != TilesIcons[4])
                {
                    previousI = i;
                    firstTileIsStart = false;
                    continue;
                }
                startIsFound = true;
                amountOfConections++;

                if (noClip)
                {
                    //first to last jump and last to first

                    //1
                    if (tile.Image == TilesIcons[1] && i == firstTileId && canJumpLast)
                    {
                        previousI = i;
                        i = lastTileId - 1;
                        continue;
                    }
                    //3
                    if (tile.Image == TilesIcons[3] && i == lastTileId && canJumpFirst)
                    {
                        previousI = i;
                        i = firstTileId - 1;
                        continue;
                    }

                    //6
                    if ((tile.Image == TilesIcons[6] || tile.Image == TilesIcons[13]) && i == lastTileId && previousI == firstTileId && canJumpUp)
                    {
                        previousI = i;
                        i -= 6;
                        continue;
                    }
                    if ((tile.Image == TilesIcons[6] || tile.Image == TilesIcons[13]) && i == lastTileId && previousI == i - 5 && canJumpFirst)
                    {
                        previousI = i;
                        i = firstTileId - 1;
                        continue;
                    }

                    //8
                    if ((tile.Image == TilesIcons[8] || tile.Image == TilesIcons[15]) && i == firstTileId && previousI == lastTileId && canJumpDown)
                    {
                        previousI = i;
                        i += 4;
                        continue;
                    }
                    if ((tile.Image == TilesIcons[8] || tile.Image == TilesIcons[15]) && i == firstTileId && previousI == i + 5 && canJumpLast)
                    {
                        previousI = i;
                        i = lastTileId - 1;
                        continue;
                    }

                    //9
                    if ((tile.Image == TilesIcons[9] || tile.Image == TilesIcons[16]) && i == firstTileId && previousI == lastTileId && canJumpRight)
                    {
                        previousI = i;
                        continue;
                    }

                    if ((tile.Image == TilesIcons[9] || tile.Image == TilesIcons[16]) && i == firstTileId && previousI == i + 1 && canJumpLast)
                    {
                        previousI = i;
                        i = lastTileId - 1;
                        continue;
                    }

                    if ((tile.Image == TilesIcons[9] || tile.Image == TilesIcons[16]) && i == lastTileId && previousI == firstTileId && canJumpLeft)
                    {
                        previousI = i;
                        i -= 2;
                        continue;
                    }

                    if ((tile.Image == TilesIcons[9] || tile.Image == TilesIcons[16]) && i == lastTileId && previousI == i - 1 && canJumpFirst)
                    {
                        previousI = i;
                        i = firstTileId - 1;
                        continue;
                    }

                    if ((tile.Image == TilesIcons[9] || tile.Image == TilesIcons[16]) && i == lastTileId && previousI == firstTileId && canJumpLeft)
                    {
                        previousI = i;
                        i -= 2;
                        continue;
                    }
                }

                //start logic

                //1
                if (tile.Image == TilesIcons[1] && canJumpLeft)
                {
                    previousI = i;
                    i -= 2;
                    continue;
                }

                //2
                if (tile.Image == TilesIcons[2] && canJumpUp)
                {
                    previousI = i;
                    i -= 6;
                    continue;
                }

                //3
                if (tile.Image == TilesIcons[3] && canJumpRight)
                {
                    previousI = i;
                    continue;
                }
                //4
                if (tile.Image == TilesIcons[4] && canJumpDown)
                {
                    previousI = i;
                    i += 4;
                    continue;
                }

                //tubes logic


                //5
                if ((tile.Image == TilesIcons[5] || tile.Image == TilesIcons[12]) && previousI == i - 1 && canJumpUp)
                {
                    previousI = i;
                    i -= 6;
                    continue;
                }
                if ((tile.Image == TilesIcons[5] || tile.Image == TilesIcons[12]) && previousI == i - 5 && canJumpLeft)
                {
                    previousI = i;
                    i -= 2;
                    continue;
                }

                //6
                if ((tile.Image == TilesIcons[6] || tile.Image == TilesIcons[13]) && previousI == i - 5 && canJumpRight)
                {
                    previousI = i;
                    continue;
                }
                if ((tile.Image == TilesIcons[6] || tile.Image == TilesIcons[13]) && previousI == i + 1 && canJumpUp)
                {
                    previousI = i;
                    i -= 6;
                    continue;
                }

                //7
                if ((tile.Image == TilesIcons[7] || tile.Image == TilesIcons[14]) && previousI == i + 5 && canJumpRight)
                {
                    previousI = i;
                    continue;
                }
                if ((tile.Image == TilesIcons[7] || tile.Image == TilesIcons[14]) && previousI == i + 1 && canJumpDown)
                {
                    previousI = i;
                    i += 4;
                    continue;
                }

                //8
                if ((tile.Image == TilesIcons[8] || tile.Image == TilesIcons[15]) && previousI == i - 1 && canJumpDown)
                {
                    previousI = i;
                    i += 4;
                    continue;
                }
                if ((tile.Image == TilesIcons[8] || tile.Image == TilesIcons[15]) && previousI == i + 5 && canJumpLeft)
                {
                    previousI = i;
                    i -= 2;
                    continue;
                }

                //9
                if ((tile.Image == TilesIcons[9] || tile.Image == TilesIcons[16]) && previousI == i - 1 && canJumpRight)
                {
                    previousI = i;
                    continue;
                }
                if ((tile.Image == TilesIcons[9] || tile.Image == TilesIcons[16]) && previousI == i + 1 && canJumpLeft)
                {
                    previousI = i;
                    i -= 2;
                    continue;
                }

                //10
                if (previousI == i - 5 && (tile.Image == TilesIcons[10] || tile.Image == TilesIcons[17]) && canJumpDown)
                {
                    previousI = i;
                    i += 4;
                    continue;
                }
                if (previousI == i + 5 && (tile.Image == TilesIcons[10] || tile.Image == TilesIcons[17]) && canJumpUp)
                {
                    previousI = i;
                    i -= 6;
                    continue;
                }

                //when 1 is end
                if ((tile.Image == TilesIcons[9] || tile.Image == TilesIcons[16]) && nextRightTile == TilesIcons[1] && previousI == i - 1)
                    break;
                if ((tile.Image == TilesIcons[7] || tile.Image == TilesIcons[14]) && nextRightTile == TilesIcons[1] && previousI == i + 5)
                    break;
                if ((tile.Image == TilesIcons[6] || tile.Image == TilesIcons[13]) && nextRightTile == TilesIcons[1] && previousI == i - 5)
                    break;

                if (noClip && !firstTileIsStart)
                {
                    if ((tile.Image == TilesIcons[9] || tile.Image == TilesIcons[16]) && nextRightTile == TilesIcons[1] && i == firstTileId && previousI == lastTileId)
                        break;
                }

                //when 2 is end
                if ((tile.Image == TilesIcons[8] || tile.Image == TilesIcons[15]) && nextDownTile == TilesIcons[2] && previousI == i - 1)
                    break;
                if ((tile.Image == TilesIcons[10] || tile.Image == TilesIcons[17]) && nextDownTile == TilesIcons[2] && previousI == i - 5)
                    break;
                if ((tile.Image == TilesIcons[7] || tile.Image == TilesIcons[14]) && nextDownTile == TilesIcons[2] && previousI == i + 1)
                    break;

                //when 3 is end
                if ((tile.Image == TilesIcons[9] || tile.Image == TilesIcons[16]) && nextLeftTile == TilesIcons[3] && previousI == i + 1)
                    break;
                if ((tile.Image == TilesIcons[5] || tile.Image == TilesIcons[12]) && nextLeftTile == TilesIcons[3] && previousI == i - 5)
                    break;
                if ((tile.Image == TilesIcons[8] || tile.Image == TilesIcons[15]) && nextLeftTile == TilesIcons[3] && previousI == i + 5)
                    break;

                if (noClip && !firstTileIsStart)
                {
                    if ((tile.Image == TilesIcons[9] || tile.Image == TilesIcons[16]) && nextLeftTile == TilesIcons[3] && previousI == firstTileId)
                        break;
                    if ((tile.Image == TilesIcons[8] || tile.Image == TilesIcons[15]) && nextLeftTile == TilesIcons[3] && previousI == firstTileId + 5)
                        break;

                    if ((tile.Image == TilesIcons[9] || tile.Image == TilesIcons[16]) && i == firstTileId && lastTile == TilesIcons[3] && previousI == i + 1)
                        break;
                }

                //when 4 is end
                if ((tile.Image == TilesIcons[5] || tile.Image == TilesIcons[12]) && nextUpTile == TilesIcons[4] && previousI == i - 1)
                    break;
                if ((tile.Image == TilesIcons[6] || tile.Image == TilesIcons[13]) && nextUpTile == TilesIcons[4] && previousI == i + 1)
                    break;
                if ((tile.Image == TilesIcons[10] || tile.Image == TilesIcons[17]) && nextUpTile == TilesIcons[4] && previousI == i + 5)
                    break;

                if (noClip && !firstTileIsStart)
                {
                    if ((tile.Image == TilesIcons[5] || tile.Image == TilesIcons[12]) && nextUpTile == TilesIcons[4] && i == lastTileId && previousI == lastTileId - 1)
                        break;
                    if ((tile.Image == TilesIcons[6] || tile.Image == TilesIcons[13]) && nextUpTile == TilesIcons[4] && i == lastTileId && previousI == firstTileId)
                        break;
                    if ((tile.Image == TilesIcons[10] || tile.Image == TilesIcons[17]) && nextUpTile == TilesIcons[4] && i == lastTileId && previousI == firstTileId + 5)
                        break;
                }


                return false;
            }
            amountOfConections--;
            return true;
        }


        private void TileRotation(ref PictureBox tile)
        {
            //knee
            if (tile.Image == TilesIcons[5])
                tile.Image = TilesIcons[6];
            else if (tile.Image == TilesIcons[6])
                tile.Image = TilesIcons[7];
            else if (tile.Image == TilesIcons[7])
                tile.Image = TilesIcons[8];
            else if (tile.Image == TilesIcons[8])
                tile.Image = TilesIcons[5];

            //regular tube
            if (tile.Image == TilesIcons[9])
                tile.Image = TilesIcons[10];
            else if (tile.Image == TilesIcons[10])
                tile.Image = TilesIcons[9];
        }

        private void RollTilesGently()
        {
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                int tileI = tableLayoutPanel1.Controls.Count - 1 - i;
                PictureBox tile = (PictureBox)tableLayoutPanel1.Controls[tileI];

                if (tile.Image == TilesIcons[5] || tile.Image == TilesIcons[6] || tile.Image == TilesIcons[6] || tile.Image == TilesIcons[8])
                    tile.Image = TilesIcons[rnd.Next(5, 9)];
                else if (tile.Image == TilesIcons[9] || tile.Image == TilesIcons[10])
                    tile.Image = TilesIcons[rnd.Next(9, 11)];

            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Check()}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = $"Осталось времени: {--time}";
            this.Text = $"Plumber game | Уровень {Levels.LevelsList[ThisLevel].Name} | Осталось времени: {time}";
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
            Application.Exit();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
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
