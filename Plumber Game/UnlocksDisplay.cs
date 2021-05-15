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
    public partial class UnlocksDisplay : Form
    {
        public UnlocksDisplay(Hat hat)
        {
            InitializeComponent();
            pictureBox1.Image = hat.Image;
        }

        public UnlocksDisplay()
        {
            InitializeComponent();
        }

        public void Attach(Point Formlocation, int FormWidth)
        {
            Point gameLocation = Formlocation;
            gameLocation.X += FormWidth - 7;
            gameLocation.Y += 30;
            this.Location = gameLocation;
        }

    }
}
