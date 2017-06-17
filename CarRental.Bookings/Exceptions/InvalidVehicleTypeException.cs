using System;

namespace CarRental.Bookings.Exceptions
{
    public class InvalidVehicleTypeException : ArgumentException
    {
        public InvalidVehicleTypeException()
        {
        }

        public InvalidVehicleTypeException(string message) : base(message)
        {
        }

        public InvalidVehicleTypeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}