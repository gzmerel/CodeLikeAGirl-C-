
namespace RideShare.Models
{
    public class ExtraLargeCar : Car
    {   
          public override void ReportDistance()
        {
            Console.WriteLine($"Extra Large Car distance is {DistanceAwayInKm}");
        }
    }
}