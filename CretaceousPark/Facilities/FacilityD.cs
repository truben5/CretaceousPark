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
            perimeter = Constants.FacilityDPerimeter; //10000

            InstantiateGenerators();
            PowerUp();
            PopulateFacility(Constants.FacilityDEmployeeCount, Constants.FacilityDSecurity);
            PrintStatus();
        }

        public void InstantiateGenerators()
        {
            Generator generator1 = new CircleGenerator();
            generator1.SetPowerLevel(0);

            Generator generator2 = new CircleGenerator();
            generator2.SetPowerLevel(2);

            Generator generator3 = new TriangleGenerator();
            generator3.SetPowerLevel(3);

            Generator generator4 = new OctagonGenerator();
            generator4.SetPowerLevel(0);


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
