using CretaceousPark.Dinosaurs;
using CretaceousPark.Generators;
using System;
using System.Collections.Generic;

namespace CretaceousPark.Facilities
{
    public class FacilityC: Facility
    {
        public FacilityC(Dinosaur dino) : base(dino)
        {
            perimeter = Constants.FacilityCPerimeter;

            InstantiateGenerators();
            PowerUp();
            PopulateFacility(Constants.FacilityCEmployeeCount, Constants.FacilityCSecurity);
            PrintStatus();
        }

        public void InstantiateGenerators()
        {
            Generator generator1 = new CircleGenerator();
            generator1.SetPowerLevel(2);

            Generator generator2 = new TriangleGenerator();
            generator2.SetPowerLevel(1);

            Generator generator3 = new TriangleGenerator();
            generator3.SetPowerLevel(3);

            Generator generator4 = new RectangleGenerator();
            generator4.SetPowerLevel(0);

            Generator generator5 = new RectangleGenerator();
            generator5.SetPowerLevel(2);

            generators = new List<Generator>()
            {
                generator1,
                generator2,
                generator3,
                generator4,
                generator5,
            };
        }
    }
}
