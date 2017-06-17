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
                new CarCalculation(),
                new VanCalculation()
            };

            var defaultCalculation = new CarCalculation();

            var vehicleMaintenanceProvider = new VehicleMaintenanceProvider();

            // G R A P H

            return new BookingService(
                        new GenericBookingRepository(), 
                        new NewBookingValidator(vehicleMaintenanceProvider), 
                        new BookingFactory(), 
                        new CostCalculator(calculations, defaultCalculation));
        }
    }
}
