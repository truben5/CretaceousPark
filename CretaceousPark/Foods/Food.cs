using System;
using System.Collections.Generic;
using System.Text;

namespace CretaceousPark.Foods
{
    public class Food
    {
        public float weight;
        public FoodType type;
        protected DateTime startingTime;
        protected TimeSpan spoilRate;

        public enum FoodType
        {
            Meat = 1, Vegetables = 2, Candy = 3
        }

        public bool IsSpoiled()
        {
            if (DateTime.Now.TimeOfDay - startingTime.TimeOfDay >= spoilRate)
            {
                return true;
            }

            return false;
        }
    }
}
