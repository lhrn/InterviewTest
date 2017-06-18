using CarRental.Bookings.Entities;

namespace CarRental.Bookings.Calculator.Calculations
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