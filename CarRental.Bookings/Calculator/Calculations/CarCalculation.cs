using CarRental.Bookings.Entities;

namespace CarRental.Bookings.Calculator.Calculations
{
    public class CarCalculation : VehicleTypeValidator<Car>, ICalculation
    {
        public float Run(IVehicle vehicle, int duration, float discount)
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