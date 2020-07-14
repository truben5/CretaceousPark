using System;
using System.Collections.Generic;
using System.Text;

namespace CretaceousPark.Generators
{
    public class RectangleGenerator: Generator
    {
        public RectangleGenerator() : base()
        {
            maxLevel = 5;
            basePower = 10000;
        }
    }
}
