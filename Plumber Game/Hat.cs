﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumber_Game
{
    public class Hat : Sprite
    {
        int hatHight;
        
        public int HatHight
        {
            get
            {
                return hatHight;
            }
            set
            {
                hatHight = value;
            }
        }

        public Hat(Image HatImage, int HatHight)
            : base(HatImage)
        {
            this.hatHight = HatHight;
        }
    }
}
