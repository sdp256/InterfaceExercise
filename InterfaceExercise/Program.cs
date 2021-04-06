using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            SUV rogue = new SUV
            {
                WheelsNumber = 4,
                MilesPerGallon = 26,
                IsRunning = true,
                Price = 19000.00,
                CompanyName = "Nissan",
                Logo = "Nissan Badge",
                CargoSize = 36,
                ThirdRow = false
            
            };

            Truck s10 = new Truck
            {
                WheelsNumber = 4,
                MilesPerGallon = 15,
                IsRunning = true,
                Price = 5000.00,
                CompanyName = "Chevy",
                Logo = "Bowtie",
                BedSize = 55,
                TrailerHitch = true
            };

            Car legacy = new Car
            {
                WheelsNumber = 4,
                MilesPerGallon = 23,
                IsRunning = false,
                Price = 8500.00,
                CompanyName = "Subaru",
                Logo = "Pleiades",
                NumberOfDoors = 4,
                Bluetooh = false
            };

            Console.WriteLine($"Our first car is a {legacy.CompanyName} which has the {legacy.Logo} logo. It has {legacy.WheelsNumber} wheels, and it gets {legacy.MilesPerGallon} Miles per gallon.");
            Console.WriteLine($"It is {legacy.IsRunning} that the car runs.");
            Console.WriteLine($"The car costs ${legacy.Price}, and it is {legacy.Bluetooh} that it has Bluetooth capabilities. It has {legacy.NumberOfDoors} doors.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Our second car is a {s10.CompanyName} which has the {s10.Logo} logo. It has {s10.WheelsNumber} wheels, and it gets {s10.MilesPerGallon} Miles per gallon.");
            Console.WriteLine($"It is {s10.IsRunning} that the car runs.");
            Console.WriteLine($"The car costs ${s10.Price}, and it has a {s10.BedSize} square inch bed. It is {s10.TrailerHitch} that it has a trailer hitch.");            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Our third car is a {rogue.CompanyName} which has the {rogue.Logo} logo. It has {rogue.WheelsNumber} wheels, and it gets {rogue.MilesPerGallon} Miles per gallon.");
            Console.WriteLine($"It is {rogue.IsRunning} that the car runs.");
            Console.WriteLine($"The car costs ${rogue.Price}, and it has a {rogue.CargoSize} square inch cargo hold. It his {rogue.ThirdRow} that it has third row seating.");

            //List<IVehicle> vehicleList = new List<IVehicle>();
            //vehicleList.Add(legacy);
            //vehicleList.Add(s10);
            //vehicleList.Add(rogue);

            //foreach (var item in vehicleList)
            //{
            //    Console.WriteLine($"Here are the stats on our three cars\n");
            //    Console.WriteLine(item.WheelsNumber);
            //    Console.WriteLine(item.MilesPerGallon);
            //    Console.WriteLine(item.IsRunning);
            //    Console.WriteLine(item.Price);
            //    Console.WriteLine(item.WheelsNumber);

            //}






        }
    }
}
