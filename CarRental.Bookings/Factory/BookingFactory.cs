using System;
using CarRental.Bookings.Entities;
using CarRental.Vehicles;

namespace CarRental.Bookings.Factory
{
    public class BookingFactory : IBookingFactory
    {
        public Booking NewBooking(IVehicle vehicle, DateTime start, int duration, string name)
        {
            return new Booking
            {
                CarId = vehicle.Id,
                RentalDate = start,
                ReturnDate = start.AddDays(duration),
                Name = name
            };
        }
    }
}