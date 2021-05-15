using Plumber_Game.Properties;
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
    public partial class Character : Form
    {
        List<Image> CharsIGS = new List<Image> { null,Resources.char_pos1, Resources.char_pos2, Resources.char_pos3 };
        List<Image> HatsIGS = new List<Image> { null, Resources.hat_1, Resources.hat_2, Resources.hat_3, Resources.hat_4 };
        Point HatLocation;

        public Character()
        {
            InitializeComponent();
            HatLocation = pictureBoxHat.Location;
        }

        public void Attach(Point Formlocation, int FormWidth = 680)
        {
            Point gameLocation = Formlocation;
            gameLocation.X += FormWidth - 7;
            gameLocation.Y += 30;
            this.Location = gameLocation;
        }

        public void ChangeCharPosition(int charID)
        {

            if (charID <= 0 || charID > 3)
                this.BackgroundImage = CharsIGS[1];
            else
            {
                
                switch (charID)
                {
                    case 1: HatLocation.X = -7; break;
                    case 2: HatLocation.X = 20; break;
                    case 3: HatLocation.X = 2; break;
                    default: break;
                }
                pictureBoxHat.Location = HatLocation;
                this.BackgroundImage = CharsIGS[charID];
            }


                   
        }

        public void ChangeCharsHat(int hatID)
        {

            if (hatID <= 0 || hatID > HatsIGS.Count-1)
                this.BackgroundImage = HatsIGS[1];
            else
            {

                switch (hatID)
                {
                    case 1: HatLocation.Y = -45; break;
                    case 2: HatLocation.Y = -38; break;
                    case 3: HatLocation.Y = -15; break;
                    case 4: HatLocation.Y = -25; break;
                    default: break;
                }
                pictureBoxHat.Location = HatLocation;
                pictureBoxHat.BackgroundImage = HatsIGS[hatID];
                Properties.Settings.Default.selectedHat = hatID;
                Properties.Settings.Default.Save();
            }
        }

        private void Character_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
            this.TransparencyKey = Color.DarkGray;
            ChangeCharsHat(Properties.Settings.Default.selectedHat);
        }


        private void Character_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        int b = 1;
        private void Character_Click(object sender, EventArgs e)
        {
            b++;
            if (b == HatsIGS.Count)
                ChangeCharsHat(b = 1);
            else
                ChangeCharsHat(b);
        }
    }
}
