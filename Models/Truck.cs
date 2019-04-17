using System;
using System.Linq;
using System.Collections.Generic;

namespace Garage
{
    public class Truck : ILand
    {
        public int Wheels { get; set; } = 4;
        public int Doors { get; set; } = 4;
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; } = "Automatic";
        public double EngineVolume { get; set; } = 8;
        public double MaxLandSpeed { get; set; } = 140;
        public void Drive()
        {
            Console.WriteLine("The truck rumbles down the road, kicking up dust");
        }
        public void Start()
        {
            throw new NotImplementedException();
        }
        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}