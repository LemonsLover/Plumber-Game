using System.Drawing;

namespace Plumber_Game
{
    public class Character : Sprite
    {
        public Point HeadLocation { get; set; }

        public Character(Image Image, Point HeadLocation)
            :base(Image)

        {
            this.HeadLocation = HeadLocation;
        }
    }
}
