using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public int WheelsNumber { get; set; }
        public int MilesPerGallon { get; set; }
        public bool IsRunning { get; set; }
        public double Price { get; set; }
        public string CompanyName { get; set; }
        public string Logo { get; set; }

        public int CargoSize { get; set; }

        public bool ThirdRow { get; set; }

    }
}
