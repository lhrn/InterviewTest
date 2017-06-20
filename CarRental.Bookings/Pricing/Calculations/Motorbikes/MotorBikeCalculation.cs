using CarRental.Vehicles;
using CarRental.Vehicles.lib;
using CarRental.Vehicles.Motorbikes;

namespace CarRental.Bookings.Pricing.Calculations.Motorbikes
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