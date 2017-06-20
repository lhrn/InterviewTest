using CarRental.Bookings.Entities;
using CarRental.Vehicles;
using CarRental.Vehicles.Cars;

namespace CarRental.Bookings.Calculator.Calculations.Cars
{
    public class CarNovember2For1Calculation : CarCalculation
    {
        public override float Run(IVehicle vehicle, int duration, float discount, Booking booking)
        {
            var car = CastToType(vehicle);

            if (CanApplyDiscount(car, duration, booking))
            {
                var durationChargable = duration / 2 + duration % 2;

                duration = durationChargable;
            }

            return base.Run(vehicle, duration, discount, booking);
        }

        //TODO -> if more conditions needed in future, then rather pass additional ICalculation[]'s to 'CarCalculation' as '(ICalculation[] subcalculations) instead'
        private static bool CanApplyDiscount(Car car, int duration, Booking booking) 
        {
            const int november = 11;

            return booking.RentalDate.Month == november
                   & duration >= 2
                   & (car.Style == CarStyle.SUV | car.Style == CarStyle.Saloon);
        }
    }
}
