using CretaceousPark.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace CretaceousPark.Dinosaurs
{
    public abstract class Dinosaur
    {
        protected Random rnd = new Random();

        public int height;
        public int weight;
        public DietType diet;
        public int runningSpeed;
        public ConditionType condition;
        public int hungerLevel;
        public int shockThreshold;

        public enum DietType
        {
            Carnivore = 1, Herbivore = 2, Omnivore = 3
        }

        public enum ConditionType
        {
            Normal = 1, Stunned = 2, Dead = 3
        }

        public void Consume(Food food)
        {
            if ((int)diet == (int)food.type || diet == DietType.Omnivore)
            {
                if (food.IsSpoiled())
                {
                    return;
                }

                if (hungerLevel > 0)
                {
                    hungerLevel--;
                }
            }
        }
    }
}
