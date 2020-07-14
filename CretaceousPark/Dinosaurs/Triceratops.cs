using System;
using System.Collections.Generic;
using System.Text;

namespace CretaceousPark.Dinosaurs
{
    public class Triceratops: Dinosaur
    {
        public Triceratops() : base()
        {
            height = rnd.Next(8, 12);
            weight = rnd.Next(13000, 26000);
            diet = DietType.Herbivore;
            runningSpeed = 15;
            condition = ConditionType.Normal;
            shockThreshold = 16;
        }
    }
}
