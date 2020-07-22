using CretaceousPark.Dinosaurs;
using CretaceousPark.Generators;
using System;
using System.Collections.Generic;
using System.Text;

namespace CretaceousPark.Facilities
{
    public class FacilityA : Facility
    {
        public FacilityA(Dinosaur dino) : base(dino)
        {
            perimeter = Constants.FacilityAPerimeter; // Parimeter is later divided from power. 15000

            InstantiateGenerators();
            PowerUp();
            PopulateFacility(Constants.FacilityAEmployeeCount, Constants.FacilityASecurity);
            PrintStatus();
        }

        public void InstantiateGenerators()
        {
            //T-Rex has 20 stock threshold
            //Total Power / Perimeter = T-Rex Stock Threshold
            //Total Power = 20 * 15000 = 300000

            //Circle Generator maximum is 2
            Generator generator1 = new CircleGenerator();
            generator1.SetPowerLevel(2); // 50000 * 2 = 100000

            Generator generator2 = new CircleGenerator();
            generator2.SetPowerLevel(2); // 50000 * 2 = 100000

            //Triangle Generator Max level is 3
            Generator generator3 = new TriangleGenerator();
            generator3.SetPowerLevel(2); // 15000 * 2  // These work well. 

            Generator generator4 = new TriangleGenerator();
            generator4.SetPowerLevel(2); // 15000 * 2 

            Generator generator5 = new TriangleGenerator();
            generator5.SetPowerLevel(0); // 15000 * 0 

            Generator generator6 = new RectangleGenerator();
            generator6.SetPowerLevel(1); // 10000 * 2 * 1 = 20000 

            Generator generator7 = new RectangleGenerator();
            generator7.SetPowerLevel(1); // 10000 * 2 * 1 = 20000

            //8 Max
            Generator generator8 = new OctagonGenerator();
            generator8.SetPowerLevel(0); // 2000 * 2 * 0 = 0

            Generator generator9 = new OctagonGenerator();
            generator9.SetPowerLevel(0); // 2000 * 0 = 0

            Generator generator10 = new OctagonGenerator();
            generator10.SetPowerLevel(0); // 2000 * 0 = 0


            generators = new List<Generator>
            { 
                generator1, 
                generator2, 
                generator3, 
                generator4, 
                generator5, 
                generator6, 
                generator7, 
                generator8, 
                generator9,
                generator10
            };
        }
    }
}
