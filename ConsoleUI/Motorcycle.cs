using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"This is a motorcycle.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"The motorcycle is moving.");
        }





    }
}