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
            perimeter = Constants.FacilityDPerimeter; //10000 ... This took me forever to realize.

            InstantiateGenerators();
            PowerUp();
            PopulateFacility(Constants.FacilityDEmployeeCount, Constants.FacilityDSecurity);
            PrintStatus();
        }

        public void InstantiateGenerators()
        {
            //Stegosaurus has 14 stock threshold
            //Total Power / Perimeter = Stock Threshold
            //Total Power = 14 * 10000 = 140000

            Generator generator1 = new CircleGenerator();
            generator1.SetPowerLevel(2); // 50000 * 2 = 100000

            Generator generator2 = new CircleGenerator();
            generator2.SetPowerLevel(0); // 50000 * 0 

            Generator generator3 = new TriangleGenerator();
            generator3.SetPowerLevel(3); // 15000 * 3 = 45000

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
