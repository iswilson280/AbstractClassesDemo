using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Make { get; set; } = "Dodge";

        public string Model { get; set; } = "Charger";

        public int Year { get; set; } = 2022;

        public abstract void Start();
        public abstract void Stop();



        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Driving the vehicle.");
        }

        





    }



}

