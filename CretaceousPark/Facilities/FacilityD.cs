using CretaceousPark.Dinosaurs;
using CretaceousPark.Generators;
using System;
using System.Collections.Generic;
using System.Text;

namespace CretaceousPark.Facilities
{
    public class FacilityD: Facility
    {
        public FacilityD(Dinosaur dino) : base(dino)
        {
            perimeter = Constants.FacilityAPerimeter;

            InstantiateGenerators();
            PowerUp();
            PopulateFacility(Constants.FacilityDEmployeeCount, Constants.FacilityDSecurity);
            PrintStatus();
        }

        public void InstantiateGenerators()
        {
            Generator generator1 = new CircleGenerator();
            generator1.SetPowerLevel(2);

            Generator generator2 = new CircleGenerator();
            generator2.SetPowerLevel(2);

            Generator generator3 = new TriangleGenerator();
            generator3.SetPowerLevel(1);

            Generator generator4 = new OctagonGenerator();
            generator4.SetPowerLevel(4);


            generators = new List<Generator>
            {
                generator1,
                generator2,
                generator3,
                generator4,
            };
        }
    }
}
