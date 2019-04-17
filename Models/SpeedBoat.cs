using System;
using System.Linq;
using System.Collections.Generic;

namespace Garage
{
    public class SpeedBoat : IWater
    {
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 8;
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxWaterSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("The speed boat zooms around making waves");
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