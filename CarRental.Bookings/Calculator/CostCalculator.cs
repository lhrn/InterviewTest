using System.Linq;
using CarRental.Bookings.Calculator.Calculations;
using CarRental.Bookings.Entities;

namespace CarRental.Bookings.Calculator
{
    public class CostCalculator
    {
        #region init

        private readonly ICalculation[] _calculations;
        private readonly ICalculation _defaultCalculation;

        public CostCalculator(ICalculation[] calculations, ICalculation defaultCalculation)
        {
            _calculations = calculations;
            _defaultCalculation = defaultCalculation;
        }

        #endregion

        public float Calculate(IVehicle vehicle, int duration, float discount)
        {
            var calculation = _calculations.FirstOrDefault(c => c.AppliesTo(vehicle)) ?? _defaultCalculation;

            var cost = calculation.Run(vehicle, duration, discount);

            return cost;
        }
    }
}