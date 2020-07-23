﻿using CretaceousPark.Dinosaurs;
using CretaceousPark.Generators;
using System;
using System.Collections.Generic;
using System.Text;

namespace CretaceousPark.Facilities
{
    public class FacilityB : Facility
    {
        public FacilityB(Dinosaur dino) : base(dino)
        {
            perimeter = Constants.FacilityBPerimeter; //4500

            InstantiateGenerators();
            PowerUp();
            PopulateFacility(Constants.FacilityBEmployeeCount, Constants.FacilityBSecurity);
            PrintStatus();
        }

        public void InstantiateGenerators()
        {
            Generator generator1 = new RectangleGenerator();
            generator1.SetPowerLevel(2);

            Generator generator2 = new RectangleGenerator();
            generator2.SetPowerLevel(0);

            Generator generator3 = new OctagonGenerator();
            generator3.SetPowerLevel(4);

            generators = new List<Generator>()
            {
                generator1,
                generator2,
                generator3
            };
        }
    }
}
