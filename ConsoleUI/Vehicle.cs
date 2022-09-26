using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
          // DONE The vehicle class shall have three string properties Year, Make, and Model
          // DONE  * Set the defaults to something generic in the Vehicle class
          // DONE * Vehicle shall have an abstract method called DriveAbstract with no implementation
          // Done  * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
    public abstract class Vehicle
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public string Name { get; set; }

        public abstract void DriveAbstract();
        

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"The vehicle is moving.");
        }





    }


}
