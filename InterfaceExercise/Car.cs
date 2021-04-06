using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public int WheelsNumber { get; set; }
        public int MilesPerGallon { get; set; }
        public bool IsRunning { get; set; }
        public double Price { get; set; }
        public string CompanyName { get; set; }
        public string Logo { get; set; }

        public int NumberOfDoors { get; set; }
        public bool Bluetooh { get; set; }


    }
}
