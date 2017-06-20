using System;

namespace CarRental.Bookings.lib.Exceptions
{
    public class CannotBookCarException : InvalidOperationException
    {
        public CannotBookCarException(string message) : base(message)
        {
        }

        public CannotBookCarException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public static CannotBookCarException New(Booking booking)
        {
            return new CannotBookCarException($"Vehicle {booking.CarId} is unavailable from {booking.RentalDate.Date} to {booking.ReturnDate.Date}");
        }
    }
}