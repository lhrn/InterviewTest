using System.Linq;
using CarRental.Bookings.Calculator.Calculations;
using CarRental.Bookings.Entities;
using CarRental.Vehicles;

namespace CarRental.Bookings.Calculator
{
    public class BookingCostCalculator : ICostCalculator
    {
        #region init

        private readonly ICalculation[] _calculations;
        private readonly ICalculation _defaultCalculation;

        public BookingCostCalculator(ICalculation[] calculations, ICalculation defaultCalculation)
        {
            _calculations = calculations;
            _defaultCalculation = defaultCalculation;
        }

        #endregion

        public float Calculate(IVehicle vehicle, int duration, float discount, Booking booking)
        {
            var calculation = _calculations.FirstOrDefault(c => c.AppliesTo(vehicle)) ?? _defaultCalculation;

            var cost = calculation.Run(vehicle, duration, discount, booking);

            return cost;
        }
    }
}