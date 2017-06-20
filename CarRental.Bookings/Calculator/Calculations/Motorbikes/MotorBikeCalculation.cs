using CarRental.Bookings.Common;
using CarRental.Bookings.Entities;
using CarRental.Vehicles;

namespace CarRental.Bookings.Calculator.Calculations.Motorbikes
{
    public class MotorBikeCalculation : VehicleTypeValidator<Motorbike>, ICalculation
    {
        public float Run(IVehicle vehicle, int duration, float discount, Booking booking)
        {
            var mb = CastToType(vehicle);

            return mb.DailyCost * duration - discount;
        }

        public bool AppliesTo(IVehicle vehicle)
        {
            return IsVehicleType<Motorbike>(vehicle);
        }
    }
}