using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * DONE Create an abstract class called Vehicle
             * DONE The vehicle class shall have three string properties Year, Make, and Model
             * DONE Set the defaults to something generic in the Vehicle class
             * DONE Vehicle shall have an abstract method called DriveAbstract with no implementation
             * DONE Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * DONE Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE Provide the implementations for the abstract methods
             * DONE Only in the Motorcycle class will you override the virtual drive method
            */

            // DONE Create a list of Vehicle called vehicles

            /*
            * DONE Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
            * DONE - new it up as one of each derived class
            * DONE  Set the properties with object initializer syntax
            */

            /*
             * DONE Add the 4 vehicles to the list
             * DONE Using a foreach loop iterate over each of the properties
             */

            // DONE Call each of the drive methods for one car and one motorcycle

            var vehicles = new List<Vehicle>();

                       

            Car car1 = new Car()
            {
                Name = "Car 1",
                Year = 2015,
                Make = "Toyota",
                Model = "Camry",
                HasTrunk = true
            };

            vehicles.Add(car1);


            Motorcycle motorcycle1 = new Motorcycle()
            {
                Name = "Motorcycle 1",
                Year = 2005,
                Make = "Honda",
                Model = "Shadow",
                HasSideCart = false
            };

            vehicles.Add(motorcycle1);
            


            Vehicle car2 = new Car()
            {
                Name = "Car 2",
                Year = 2018,
                Make = "Chevy",
                Model = "Silverado",
                HasTrunk = false,
            };

            vehicles.Add(car2);


            Vehicle motorcycle2 = new Motorcycle()
            {
                Name = "Motorcycle 2",
                Year = 2022,
                Make = "Yamaha",
                Model = "Moped",
                HasSideCart = true
            };

            vehicles.Add(motorcycle2);

            

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Name: {vehicle.Name}");
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine();
                Console.WriteLine();

            }


            car1.DriveAbstract();
            car2.DriveVirtual();


            motorcycle2.DriveAbstract();
            motorcycle2.DriveVirtual();
            
           

            #endregion            
            Console.ReadLine();
        }
    }
}
