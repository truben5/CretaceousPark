using System;
using System.Collections.Generic;
using System.Text;

namespace CretaceousPark.Dinosaurs
{
    public class Stegosaurus : Dinosaur
    {
        public Stegosaurus() : base()
        {
            height = rnd.Next(12, 18);
            weight = rnd.Next(8000, 16000);
            diet = DietType.Herbivore;
            runningSpeed = 10;
            condition = ConditionType.Normal;
            shockThreshold = 14;
        }
    }
}
