using System;
using System.Collections.Generic;
using System.Text;

namespace CretaceousPark.Generators
{
    public class TriangleGenerator: Generator
    {
        public TriangleGenerator(): base()
        {
            maxLevel = 3;
            basePower = 15000;
        }
    }
}
