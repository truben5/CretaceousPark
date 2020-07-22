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
            perimeter = Constants.FacilityCPerimeter; //12000

            InstantiateGenerators();
            PowerUp();
            PopulateFacility(Constants.FacilityCEmployeeCount, Constants.FacilityCSecurity);
            PrintStatus();
        }

        public void InstantiateGenerators()
        {
            //Triceratops has 16 stock threshold
            //Total Power / Perimeter = Stock Threshold
            //Total Power = 16 * 12000 = 192000 
            //Oh look, 192000 is pretty close to 200000... I wonder how I can reach that easily.
            //This one uses the neat Floor(Total Power / Perimeter) to reach threshold.


            Generator generator1 = new CircleGenerator();
            generator1.SetPowerLevel(2); // 50000 * 2 = 100000

            Generator generator2 = new TriangleGenerator();
            generator2.SetPowerLevel(2); // 15000 * 2 = 30000

            Generator generator3 = new TriangleGenerator();
            generator3.SetPowerLevel(2); // 15000 * 2 = 30000

            Generator generator4 = new RectangleGenerator();
            generator4.SetPowerLevel(1); // 10000 * 2 * 1 = 20000

            Generator generator5 = new RectangleGenerator();
            generator5.SetPowerLevel(1); // 10000 * 2 * 1 = 20000

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
