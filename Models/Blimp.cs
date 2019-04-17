using System;
using System.Linq;
using System.Collections.Generic;

namespace Garage
{
    public class Blimp : IAir
    {
    public int Wheels { get; set; } = 4;
    public int Doors { get; set; } = 6;
    public int PassengerCapacity { get; set; } = 250;
    public bool Winged { get; set; } = false;
    public string TransmissionType { get; set; } = "None";
    public double EngineVolume { get; set; } = 25;
    public double MaxAirSpeed { get; set; } = 78;

    public void Fly()
    {
        Console.WriteLine("The Blimp floats uselessly about");
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