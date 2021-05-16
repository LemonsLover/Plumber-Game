using System.Drawing;

namespace Plumber_Game
{
    public class Character : Sprite
    {
        Point headLocation;

        public Point HeadLocation
        {
            get
            {
                return headLocation;
            }
            set
            {
                headLocation = value;
            }
        }

        public Character(Image Image, Point HeadLocation)
            :base(Image)

        {
            this.headLocation = HeadLocation;
        }
    }
}
