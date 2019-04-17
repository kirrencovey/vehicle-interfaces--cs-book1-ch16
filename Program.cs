using System;
using System.Linq;
using System.Collections.Generic;

namespace Garage
{
    public class Program
    {
        public static void Main() {

            Cessna plane = new Cessna();
            Blimp blimpy = new Blimp();
            Motorcycle bike = new Motorcycle();
            Truck bigtruck = new Truck();
            JetSki zippy = new JetSki();
            SpeedBoat speedy = new SpeedBoat();

            // Build a collection of all vehicles that fly

            List<IAir> FlyingVehicles = new List<IAir>() {
                plane, blimpy
            };

            // With a single `foreach`, have each vehicle Fly()

            FlyingVehicles.ForEach(v => v.Fly());


            // Build a collection of all vehicles that operate on roads

            List<ILand> LandVehicles = new List<ILand>() {
                bike, bigtruck
            };

            // With a single `foreach`, have each road vehicle Drive()

            LandVehicles.ForEach(v => v.Drive());


            // Build a collection of all vehicles that operate on water

            List<IWater> WaterVehicles = new List<IWater>() {
                zippy, speedy
            };

            // With a single `foreach`, have each water vehicle Drive()

            WaterVehicles.ForEach(v => v.Drive());

        }

    }
}
