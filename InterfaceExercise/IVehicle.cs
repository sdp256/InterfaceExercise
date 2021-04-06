using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public int WheelsNumber { get; set; }
        public int MilesPerGallon { get; set; }
        public bool IsRunning { get; set; }
        public double Price { get; set; }

    }
}
