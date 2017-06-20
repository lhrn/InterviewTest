using CarRental.Bookings.Common;
using CarRental.Bookings.Entities;
using CarRental.Vehicles;

namespace CarRental.Bookings.Calculator.Calculations.Cars
{
    public class CarCalculation : VehicleTypeValidator<Car>, ICalculation
    {
        public virtual float Run(IVehicle vehicle, int duration, float discount, Booking booking)
        {
            var car = CastToType(vehicle);

            return car.DailyCost * duration - discount;
        }

        public bool AppliesTo(IVehicle vehicle)
        {
            return IsVehicleType<Car>(vehicle);
        }
    }
}