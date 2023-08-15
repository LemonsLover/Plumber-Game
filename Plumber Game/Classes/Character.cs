using System.Drawing;

namespace Plumber_Game
{
    public class Character : Sprite
    {
        public Point HeadLocation { get; set; }

        public Character(Image image, Point headLocation)
            :base(image)

        {
            HeadLocation = headLocation;
        }
    }
}
