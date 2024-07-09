using System;
using RideShare.Models;

namespace RideShare
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicle1 = new Vehicle();
            var car1  = new Car();
            var extralargeCar1= new ExtraLargeCar();

            vehicle1.ReportDistance();
            car1.ReportDistance();
            extralargeCar1.ReportDistance();
        }
    }
    
}