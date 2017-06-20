using CarRental.Bookings.Entities;
using CarRental.Vehicles;

namespace CarRental.Bookings.Calculator
{
    public interface ICostCalculator
    {
        float Calculate(IVehicle vehicle, int duration, float discount, Booking booking);
    }
}