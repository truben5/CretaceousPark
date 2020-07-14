using System;
using System.Collections.Generic;
using System.Text;

namespace CretaceousPark.Foods
{
    public class Meat: Food
    {
        public Meat(float weight)
        {
            weight = this.weight;
            type = FoodType.Meat;
            spoilRate = new TimeSpan(5);
        }
    }
}
