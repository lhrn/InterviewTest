using System;
using CarRental.Bookings.Entities;

namespace CarRental.Bookings
{
    public class BookingFactory
    {
        public Booking NewBooking(Car car, DateTime start, int duration, string name)
        {
            return new Booking
            {
                CarId = car.Id,
                RentalDate = start,
                ReturnDate = start.AddDays(duration),
                Name = name
            };
        }
    }
}