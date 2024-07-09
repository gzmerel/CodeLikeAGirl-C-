
using System.IO.Compression;

namespace RideShare.Models
{
    public class LuxuryCar : Vehicle
    {
        public override void ReportDistance()
        {
            Console.WriteLine("This must be the Luxury Car");
        }
    }
}