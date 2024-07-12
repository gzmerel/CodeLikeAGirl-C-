
namespace RideShare.Models
{
    public class Car : Vehicle
    {
            public override void ReportDistance()
        {
            Console.WriteLine($"The Car distance is {DistanceAwayInKm}");
        }
    }
}