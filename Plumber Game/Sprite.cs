using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumber_Game
{
    public class Sprite
    {
        Image image;
        Size size;

        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }
        }

        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        public Sprite(Image Image)
        {
            this.image = Image;
            this.size = Image.Size;
        }

        public Sprite(Image Image, Size Size)
        {
            this.image = Image;
            this.size = Size;
        }
    }
}
