using System;
using System.Collections.Generic;
using System.Text;

namespace CretaceousPark.Dinosaurs
{
    public class Velociraptor: Dinosaur
    {
        public Velociraptor(): base()
        {
            height = rnd.Next(6, 8);
            weight = rnd.Next(100,140);
            diet = DietType.Carnivore;
            runningSpeed = 40;
            condition = ConditionType.Normal;
            shockThreshold = 12;
        }
    }
}
