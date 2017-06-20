using System;
using CarRental.Vehicles;

namespace CarRental.Bookings.lib.Factory
{
    public interface IBookingFactory
    {
        Booking NewBooking(IVehicle vehicle, DateTime start, int duration, string name);
    }
}