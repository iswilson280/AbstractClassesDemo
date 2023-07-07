using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
             * Create an abstract class called Vehicle - done
             * The vehicle class shall have three string properties Year, Make, and Model - done
             * Set the defaults to something generic in the Vehicle class- done
             * Vehicle shall have an abstract method called DriveAbstract with no implementation- done
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. - done
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle- done
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle - done
             * Provide the implementations for the abstract methods - done
             * Only in the Motorcycle class will you override the virtual drive method- done
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax- done
             */

            /*
             * Add the 4 vehicles to the list- done
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            

            List<Vehicle> vehicles = new List<Vehicle>();

            Car car = new Car
            {
                Make = "Dodge",
                Model = "Charger",
                Year = 2022,
                HasTrunk = true
            };

            Motorcycle motorcycle = new Motorcycle
            {
                Make = "Harley-Davidson",
                Model = "Sportster",
                Year = 2021,
                HasSideCart = false
            };

            Vehicle vehicle1 = new Car
            {
                Make = "Ford",
                Model = "Mustang",
                Year = 2023,
                HasTrunk = true
            };

            Vehicle vehicle2 = new Motorcycle
            {
                Make = "Honda",
                Model = "CBR600RR",
                Year = 2022,
                HasSideCart = false
            };

            vehicles.Add(motorcycle);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            vehicles.Add(car);
            

            foreach (var item in vehicles)
            {
                Console.WriteLine(item.Make);
                Console.WriteLine(item.Model);
                Console.WriteLine(item.Year);

                Console.WriteLine();




            }



        }


    }
}
