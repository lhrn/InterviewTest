using CarRental.Bookings.Entities;

namespace CarRental.Bookings.Calculator.Calculations
{
    public class VanCalculation : ICalculation
    {
       

        public float Run(IVehicle vehicle, int duration, float discount)
        {
            throw new System.NotImplementedException();
        }

        public bool AppliesTo(IVehicle vehicle)
        {
            var applies = vehicle is Van;

            return applies;
        }
    }
}