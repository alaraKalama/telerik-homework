﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class House : StaticObject
    {
        private const int houseInitialHitPoints = 500;

        public House(Point position, int owner = 0)
            : base(position, owner)
        {
            this.HitPoints = houseInitialHitPoints;
        }
    }
}
