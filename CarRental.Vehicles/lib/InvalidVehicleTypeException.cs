using System;

namespace CarRental.Vehicles.lib
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