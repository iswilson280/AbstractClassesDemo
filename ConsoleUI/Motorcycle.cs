using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }


        public override void Start()
        {
            Console.WriteLine("Starting the motorcycle.");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping the motorcycle.");
        }

        public override void DriveAbstract()
        {
            Console.WriteLine("Driving the motorcycle.");
        }


        public override void DriveVirtual()
        {
            Console.WriteLine("Driving the motorcycle with style.");
        }


        
    }
}

