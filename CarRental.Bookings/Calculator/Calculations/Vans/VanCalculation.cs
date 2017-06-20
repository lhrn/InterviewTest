using CarRental.Bookings.Common;
using CarRental.Bookings.Entities;
using CarRental.Vehicles;
using CarRental.Vehicles.Vans;

namespace CarRental.Bookings.Calculator.Calculations.Vans
{
    public class VanCalculation : VehicleTypeValidator<Van>, ICalculation
    {
        public float Run(IVehicle vehicle, int duration, float discount, Booking booking)
        {
            var van = CastToType(vehicle);

            var hireCost = duration * (float)van.DailyCost;

            if (duration > 5)
            {
                discount = (float)(discount + hireCost * 0.25);
            }

            var cost = hireCost - discount;

            return cost;
        }

        public bool AppliesTo(IVehicle vehicle)
        {
            return IsVehicleType<Van>(vehicle);
        }
    }
}