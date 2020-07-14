using System;
using System.Collections.Generic;
using System.Text;

namespace CretaceousPark.Generators
{
    public abstract class Generator
    {
        protected bool turnedOn = false;
        protected int basePower;
        protected int level = 0;
        protected int maxLevel;

        public void ShutDown()
        {
            level = 0;
            turnedOn = false;
        }

        public void StartUp()
        { 
            turnedOn = true;
        }

        public void SetPowerLevel(int powerLevel)
        {
            var generatorType = this.GetType().Name;
            if (generatorType == "OctagonGenerator" || generatorType == "RectangleGenerator")
            {
                powerLevel *= 2;
            }

            if (powerLevel <= maxLevel && powerLevel > 0)
            {
                level = powerLevel;
            }
        }

        public void IncreasePowerLevel()
        {
            level++;
        }

        public void DecreasePowerLevel()
        {
            if (level > 0)
            {
                level--;
            }
        }

        public int CalculatePowerPerSecond()
        {
            if (turnedOn && level > 0 && level <= maxLevel)
            {
                return basePower * level;
            }

            return 0;
        }
    }
}
