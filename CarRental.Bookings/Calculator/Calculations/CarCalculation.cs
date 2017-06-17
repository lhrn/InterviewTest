using CarRental.Bookings.Entities;
using CarRental.Bookings.Exceptions;

namespace CarRental.Bookings.Calculator.Calculations
{
    public class CarCalculation : ICalculation
    {
        public float Run(IVehicle vehicle, int duration, float discount)
        {
            var car = vehicle as Car;

            if (car == null)
                throw new InvalidVehicleTypeException($"vehicle is not of expected type {nameof(Car)}");

            return car.DailyCost * duration - discount;
        }

        public bool AppliesTo(IVehicle vehicle)
        {
            var applies = vehicle is Car;

            return applies;
        }
    }
}