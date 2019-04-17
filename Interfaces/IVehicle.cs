using System;
using System.Linq;
using System.Collections.Generic;

namespace Garage
{
    // Use your knowledge of the Interface Segregation Principle and the Dependency Inversion Principle to convert the code below into a system that is more flexible and extensible to accomodate any kind of vehicle class. Each class should only implement code that it needs.
    public interface IVehicle
    {
        int Wheels { get; set; }
        int Doors { get; set; }
        int PassengerCapacity { get; set; }
        bool Winged { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
        double MaxWaterSpeed { get; set; }
        double MaxLandSpeed { get; set; }
        double MaxAirSpeed { get; set; }
        void Start();
        void Stop();
        void Drive();
        void Fly();
    }
}