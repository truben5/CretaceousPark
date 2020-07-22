using CretaceousPark.Dinosaurs;
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
            //Velociraptor has 12 stock threshold
            //Total Power / Perimeter = Stock Threshold
            //Total Power = 12 * 4500 = 54000
            //This one uses the neat Floor(Total Power / Perimeter) to reach threshold.
            
            Generator generator1 = new RectangleGenerator();
            generator1.SetPowerLevel(1); // 10000 * 2 * 1 = 20000

            Generator generator2 = new RectangleGenerator();
            generator2.SetPowerLevel(1); // 10000 * 2 * 1 = 20000

            Generator generator3 = new OctagonGenerator();
            generator3.SetPowerLevel(4); // 2000 * 2 * 4 = 16000

            generators = new List<Generator>()
            {
                generator1,
                generator2,
                generator3
            };
        }
    }
}
