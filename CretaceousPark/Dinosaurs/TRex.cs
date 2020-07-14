using System;
using System.Collections.Generic;
using System.Text;

namespace CretaceousPark.Dinosaurs
{
    public class TRex: Dinosaur
    {
        public TRex() : base()
        {
            height = rnd.Next(8,13);
            weight = rnd.Next(7000, 20000);
            diet = DietType.Herbivore;
            runningSpeed = 15;
            condition = ConditionType.Normal;
            shockThreshold = 20;
        }
    }
}
