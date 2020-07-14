using System;
using System.Collections.Generic;
using System.Text;

namespace CretaceousPark.Foods
{
    public class Vegetable: Food
    {
        public Vegetable(float weight)
        {
            weight = this.weight;
            type = FoodType.Vegetables;
            spoilRate = new TimeSpan(10);
        }
    }
}
