using Plumber_Game.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plumber_Game
{
    class GameField
    {
        public static int amountOfConections = 0;
        public static bool noClip { get; set; } = false;

        public int CorrectLevel = 1;

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

        Random rnd = new Random();

        TableLayoutPanel Field;

        public GameField(TableLayoutPanel Field, int CorrectLevel)
        {
            this.Field = Field;
            this.CorrectLevel = CorrectLevel;
        }

        public void Update(Level Level, int CorrectLevel)
        {
            PictureBox tile;
            do
            {
                for (int i = 0; i < Field.Controls.Count; i++)
                {

                    tile = (PictureBox)Field.Controls[Field.Controls.Count - 1 - i];

                    tile.Image = TilesIcons[Level.LevelArr[i]];
                    if (Level.LevelArr[i] == 0)
                    {
                        if (CorrectLevel == 0 || CorrectLevel > 15)
                        {
                            int rand = rnd.Next(0, 101);
                            if (rand >= 0 && rand <= 80)
                                tile.Image = TilesIcons[rnd.Next(5, 11)];
                            else if (rand >= 80 && rand < 90)
                                tile.Image = TilesIcons[rnd.Next(12, 18)];
                            else
                                tile.Image = TilesIcons[11];
                        }

                        else if (CorrectLevel <= 5)
                            tile.Image = TilesIcons[rnd.Next(5, 11)];

                        else if (CorrectLevel > 5 && CorrectLevel <= 10)
                        {
                            int rand = rnd.Next(0, 101);
                            if (rand <= 90)
                                tile.Image = TilesIcons[rnd.Next(5, 11)];
                            else
                                tile.Image = TilesIcons[11];
                        }
                        else if (CorrectLevel > 10 && CorrectLevel <= 15)
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
            } while (!Check(noClip) && CorrectLevel == 0 && !Level.IsCastom);
            RollTilesGently();
        }

        private void RollTilesGently()
        {
            for (int i = 0; i < Field.Controls.Count; i++)
            {
                int tileI = Field.Controls.Count - 1 - i;
                PictureBox tile = (PictureBox)Field.Controls[tileI];

                if (tile.Image == TilesIcons[5] || tile.Image == TilesIcons[6] || tile.Image == TilesIcons[6]
                    || tile.Image == TilesIcons[8])
                    tile.Image = TilesIcons[rnd.Next(5, 9)];
                else if (tile.Image == TilesIcons[9] || tile.Image == TilesIcons[10])
                    tile.Image = TilesIcons[rnd.Next(9, 11)];

            }
        }

        public static void RotateTile(ref PictureBox tile)
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


        public bool Check(bool noClip = false)
        {
            int previousI = 0;
            bool startIsFound = false, firstTileIsStart = true;
            amountOfConections = 0;
            for (int i = 0; i < Field.Controls.Count; i++)
            {
                int tileI = Field.Controls.Count - 1 - i;
                PictureBox tile = (PictureBox)Field.Controls[tileI];
                Image nextRightTile = TilesIcons[0], nextDownTile = TilesIcons[0], nextUpTile = TilesIcons[0], nextLeftTile = TilesIcons[0], lastTile = TilesIcons[0],
                    firstTile = TilesIcons[0];

                if (i != Field.Controls.Count - 1)
                    nextRightTile = ((PictureBox)Field.Controls[tileI - 1]).Image;
                if (i != 0)
                    nextLeftTile = ((PictureBox)Field.Controls[tileI + 1]).Image;
                if (i < Field.Controls.Count - 5)
                    nextDownTile = ((PictureBox)Field.Controls[tileI - 5]).Image;
                if (i >= 5)
                    nextUpTile = ((PictureBox)Field.Controls[tileI + 5]).Image;

                lastTile = ((PictureBox)Field.Controls[0]).Image;
                firstTile = ((PictureBox)Field.Controls[Field.Controls.Count - 1]).Image;
                int lastTileId = Field.Controls.Count - 1;
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
                    if ((tile.Image == TilesIcons[9] || tile.Image == TilesIcons[16]) && nextLeftTile == TilesIcons[3] && previousI == firstTileId && i == firstTileId)
                        break;
                    if ((tile.Image == TilesIcons[8] || tile.Image == TilesIcons[15]) && nextLeftTile == TilesIcons[3] && previousI == firstTileId + 5 && i == firstTileId)
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

    }
}
