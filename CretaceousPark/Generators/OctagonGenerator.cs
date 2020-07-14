using System;
using System.Collections.Generic;
using System.Text;

namespace CretaceousPark.Generators
{
    public class OctagonGenerator: Generator
    {
        public OctagonGenerator() : base()
        {
            maxLevel = 8;
            basePower = 2000;
        }
    }
}
