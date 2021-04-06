using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int WheelsNumber { get; set; }
        public int MilesPerGallon { get; set; }
        public bool IsRunning { get; set; }
        public double Price { get; set; }
        public string CompanyName { get; set; }
        public string Logo { get; set; }
        public int BedSize { get; set; }
        public bool TrailerHitch { get; set; }

    }
}
