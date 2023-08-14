using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumber_Game
{
    public class Hat : Sprite
    {        
        public int HatHight { get; set; }

        public Hat(Image HatImage, int HatHight)
            : base(HatImage)
        {
            this.HatHight = HatHight;
        }
    }
}
