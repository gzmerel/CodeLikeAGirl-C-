using System;
using RideShare.Models;

namespace RideShare
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1  = new Car();

            var luxuryCar1= new LuxuryCar();

            car1.ReportDistance();
            car1.DistanceAwayInKm = 3.5;
            
            extralargeCar1.ReportDistance();


             var vehicles = new List<Vehicle>
             {
                new Car(),
                new ExtraLargeCar(),
                new LuxuryCar()

             };


        }
    }
    
}