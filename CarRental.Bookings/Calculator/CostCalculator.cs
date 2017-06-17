using CarRental.Bookings.Entities;

namespace CarRental.Bookings.Calculator
{
    public class CostCalculator
    {
        public float CalculateTotalCost(Car car, int duration, float discount)
        {
            return car.DailyCost * duration - discount;
        }
    }
}