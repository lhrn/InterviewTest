using CarRental.Vehicles;

namespace CarRental.Bookings.Pricing
{
    public interface ICostCalculator
    {
        float Calculate(IVehicle vehicle, int duration, float discount, Booking booking);
    }
}