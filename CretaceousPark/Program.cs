using CretaceousPark.Dinosaurs;
using CretaceousPark.Facilities;
using System;
using System.Collections.Generic;
using System.Threading;

namespace CretaceousPark
{
    class Program
    {
        // DO NOT EDIT FILE
        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("\nWelcome to Cretaceous Park Systems {0}\n\n", Constants.versionNumber));

            bool signIn = false;
            
            while (signIn == false)
            {
                Console.WriteLine("Please log in as admin to begin...");
                Console.WriteLine("Username: ");
                string name = Console.ReadLine();
                Console.WriteLine("Password: ");
                string pass = Console.ReadLine();

                if (name != Constants.adminName || pass != Constants.adminPass)
                {
                    Console.WriteLine("\nError: Invalid username or password\n");
                }
                else
                {
                    signIn = true;
                    Console.WriteLine("\nCredentials accepted, signing in...\n");
                }
            } 

            Console.WriteLine("Booting up Cretaceous Park...");
            Console.WriteLine("Current Dinosaur Species on Island: \n");
            foreach(string dino in Constants.allDinosaurTypes)
            {
                Console.WriteLine(dino);
                Thread.Sleep(100);
            }

            Console.WriteLine("\nBooting up Facility A...");
            FacilityA fA = new FacilityA(new TRex());

            Console.WriteLine("\nBooting up Facility B...");
            FacilityB fB = new FacilityB(new Velociraptor());

            Console.Write("\nBooting up Facility C...");
            FacilityC fC = new FacilityC(new Triceratops());

            Console.WriteLine("\nBooting up Facility D...");
            FacilityD fD = new FacilityD(new Stegosaurus());

            if (fA.functioning && fB.functioning && fC.functioning && fD.functioning)
            {
                Console.WriteLine("\nCretacous Park is successfully up and running\n");
                Console.WriteLine(Constants.SuccessPicture);
            }
            else
            {
                // I don't expect this to happen
                // Will fill out later
                throw new Exception();
            }


        }
    }
}
