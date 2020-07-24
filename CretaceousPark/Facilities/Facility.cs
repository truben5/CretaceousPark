using CretaceousPark.Dinosaurs;
using CretaceousPark.Employees;
using CretaceousPark.Foods;
using CretaceousPark.Generators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CretaceousPark.Facilities
{
    public abstract class Facility
    {
        public int longitude;
        public int latitude;
        public int perimeter;
        public bool functioning;
        protected List<Generator> generators = new List<Generator>();
        protected int maxEmployeeSize;
        protected List<Employee> employees = new List<Employee>();
        protected int totalPower;
        private Dinosaur dinosaur;

        public Facility(Dinosaur dino)
        {
            dinosaur = dino;
        }

        public void PowerUp()
        {
            Thread.Sleep(750);
            foreach (Generator generator in generators)
            {
                generator.StartUp();
                totalPower += generator.CalculatePowerPerSecond();
            }

            int distributedPower = CalculateDistributedPower();

            functioning = distributedPower >= dinosaur.shockThreshold;
        }

        public void PowerDown()
        {
            foreach(Generator generator in generators)
            {
                totalPower -= generator.CalculatePowerPerSecond();
                generator.ShutDown();
            }
        }

        public void FeedDino()
        {
            Food food;

            if (dinosaur.diet == Dinosaur.DietType.Carnivore)
            {
                food = new Meat(1);
            }
            else
            {
                food = new Vegetable(2);
            }

            dinosaur.Consume(food);

        }

        protected void PrintStatus()
        {
            Console.WriteLine("Distributed Power: " + CalculateDistributedPower());
            if (functioning)
            {
                Console.WriteLine("Facility functioning correctly and securely containing dinosaurs");
            }
            else
            {
                Console.WriteLine("\n\nWARNING: FACILITY NOT FUNCTIONING CORRECTLY. DINOSAURS MAY NOT BE CONTAINED\n\n");
            }
        }

        public int CalculateDistributedPower() {
            return totalPower / perimeter;
        }

        protected void PopulateFacility(int staffCount, int securityLevel)
        {
            for (int i = 0; i < staffCount; i++)
            {
                Employee e = new Employee(i, securityLevel, dinosaur);
                employees.Add(e);
            }
        }
    }
}
