using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; }


        public override void Start()
        {
            Console.WriteLine("Starting the car.");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping the car.");
        }

        public override void DriveAbstract()
        {
            Console.WriteLine("Driving the car.");
        }

       



    }


}

