using System;
using CarRental.Bookings.Entities;
using CarRental.Vehicles;

namespace CarRental.Bookings.Factory
{
    public interface IBookingFactory
    {
        Booking NewBooking(IVehicle vehicle, DateTime start, int duration, string name);
    }
}