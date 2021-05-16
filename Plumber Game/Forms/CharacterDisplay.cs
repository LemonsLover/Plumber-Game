using Plumber_Game.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Plumber_Game
{
    public partial class CharacterDisplay : Form
    {
        static List<Hat> hats = new List<Hat> { null, new Hat(Resources.hat_1, 32), new Hat(Resources.hat_2, 30), new Hat(Resources.hat_3, 5), new Hat(Resources.hat_4, 20),
        new Hat(Resources.hat_5, 20), new Hat(Resources.hat_6, 42)};
        static List<Character> characterPos = new List<Character> { null, new Character(Resources.char_pos1, new Point(-11, 0)), new Character(Resources.char_pos2, new Point(23, 0)),
        new Character(Resources.char_pos3, new Point(-9, 0))};

        Point HatLocation;

        
        public static int AvalibleHats = Properties.Settings.Default.avalibleHats;

        int _selectedHat = Properties.Settings.Default.selectedHat;
        int _charPosotion = 1;

        public CharacterDisplay()
        {
            InitializeComponent();
            HatLocation = pictureBoxHat.Location;
        }

        public static Hat UnlockHat()
        {
            if (AvalibleHats != hats.Count - 1)
            {
                Properties.Settings.Default.avalibleHats = AvalibleHats++;
                Properties.Settings.Default.Save();
            }

            return hats[AvalibleHats];
        }

        public void ChangeCharPosition(int charID)
        {

            if (charID <= 0 || charID > 3)
            {
                this.BackgroundImage = characterPos[1].Image;
                _charPosotion = 1;
            }
            else
            {
                _charPosotion = charID;

                HatLocation = characterPos[charID].HeadLocation;
                HatLocation.Y -= hats[_selectedHat].HatHight;

                pictureBoxHat.Location = HatLocation;
                this.BackgroundImage = characterPos[charID].Image;
            }
        }

        public void ChangeCharsHat()
        {
            HatLocation = characterPos[_charPosotion].HeadLocation;
            HatLocation.Y -= hats[_selectedHat].HatHight;

            pictureBoxHat.Location = HatLocation;
            pictureBoxHat.BackgroundImage = hats[_selectedHat].Image;
            Properties.Settings.Default.selectedHat = _selectedHat;
            Properties.Settings.Default.Save();
        }

        private void Character_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
            this.TransparencyKey = Color.DarkGray;
            ChangeCharsHat();
        }

        public void Attach(Point Formlocation, int FormWidth)
        {
            Point gameLocation = Formlocation;
            gameLocation.X += FormWidth - 7;
            gameLocation.Y += 30;
            this.Location = gameLocation;
        }


        private void Character_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Character_Click(object sender, EventArgs e)
        {

            if (_selectedHat >= AvalibleHats)
            {
                _selectedHat = 1;
                ChangeCharsHat();
            }
            else
            {
                _selectedHat++;
                ChangeCharsHat();
            }
        }
    }
}
