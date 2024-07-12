
using System.IO.Compression;

namespace RideShare.Models
{
    public class LuxuryCar : Car
    {
        
        public override void ReportDistance()
        {
            Console.WriteLine($"Luxury Car distance is {DistanceAwayInKm}");
        }
    }
}