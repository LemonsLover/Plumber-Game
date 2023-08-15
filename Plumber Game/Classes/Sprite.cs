using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumber_Game
{
    public abstract class Sprite
    {
        public Image Image { get; set; }

        public Size Size { get; set; }

        public Sprite(Image image)
        {
            this.Image = image;
            this.Size = image.Size;
        }

        public Sprite(Image image, Size size)
        {
            this.Image = image;
            this.Size = size;
        }
    }
}
