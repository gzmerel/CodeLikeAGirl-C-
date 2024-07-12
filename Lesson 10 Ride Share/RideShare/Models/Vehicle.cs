
namespace RideShare.Models
{
    public class Vehicle
    {
    public double DistanceAwayInKm { get; set; }
       public virtual void  ReportDistance()
       {
            Console.WriteLine($"Report Distance {DistanceAwayInKm}");
       }
    }
}