using CarRental.Bookings.Calculator;
using CarRental.Bookings.Calculator.Calculations;
using CarRental.Bookings.Factory;
using CarRental.Bookings.Validation;

namespace CarRental.Bookings.Module
{
    public class BookingsModule
    {
        public static BookingService GetService()
        {
            // S E T U P

            ICalculation[] calculations = {
                new CarCalculation()
            };

            var defaultCalculation = new CarCalculation();

            // G R A P H

            return new BookingService(
                        new BookingRepository(), 
                        new NewBookingValidator(), 
                        new BookingFactory(), 
                        new CostCalculator(calculations, defaultCalculation));
        }
    }
}
