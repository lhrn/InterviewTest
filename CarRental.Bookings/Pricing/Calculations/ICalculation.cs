using CarRental.Vehicles;

namespace CarRental.Bookings.Pricing.Calculations
{
    public interface ICalculation
    {
        float Run(IVehicle vehicle, int duration, float discount, Booking booking);

        bool AppliesTo(IVehicle vehicle);
    }
}