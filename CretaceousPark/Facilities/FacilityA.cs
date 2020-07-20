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
            perimeter = Constants.FacilityAPerimeter;

            InstantiateGenerators();
            PowerUp();
            PopulateFacility(Constants.FacilityAEmployeeCount, Constants.FacilityASecurity);
            PrintStatus();
        }

        public void InstantiateGenerators()
        {
            Generator generator1 = new CircleGenerator();
            generator1.SetPowerLevel(2);

            Generator generator2 = new CircleGenerator();
            generator2.SetPowerLevel(1);

            Generator generator3 = new TriangleGenerator();
            generator3.SetPowerLevel(1);

            Generator generator4 = new TriangleGenerator();
            generator4.SetPowerLevel(3);

            Generator generator5 = new TriangleGenerator();
            generator5.SetPowerLevel(1);

            Generator generator6 = new RectangleGenerator();
            generator6.SetPowerLevel(1);

            Generator generator7 = new RectangleGenerator();
            generator7.SetPowerLevel(2);

            Generator generator8 = new OctagonGenerator();
            generator8.SetPowerLevel(4);

            Generator generator9 = new OctagonGenerator();
            generator9.SetPowerLevel(1);

            Generator generator10 = new OctagonGenerator();
            generator10.SetPowerLevel(1);


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
