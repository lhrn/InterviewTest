using CarRental.Bookings.lib.Factory;
using CarRental.Bookings.lib.Validation;
using CarRental.Bookings.Pricing;
using CarRental.Bookings.Pricing.Calculations;
using CarRental.Bookings.Pricing.Calculations.Cars;
using CarRental.Bookings.Pricing.Calculations.Motorbikes;
using CarRental.Bookings.Pricing.Calculations.Vans;
using CarRental.Vehicles.lib;

namespace CarRental.Bookings.lib.Module
{
    public class BookingsModule
    {
        public static BookingService GetService()
        {
            // S E T U P

            ICalculation[] calculations = {
                //new CarCalculation(),
                new CarNovember2For1Calculation(), 
                new MotorBikeCalculation(), 
                new VanCalculation()
            };

            var defaultCalculation = new CarCalculation();

            var vehicleMaintenanceProvider = new VehicleMaintenanceProvider();

            // G R A P H

            return new BookingService(
                        new BookingRepository(), 
                        new NewBookingValidator(vehicleMaintenanceProvider), 
                        new BookingFactory(), 
                        new BookingCostCalculator(calculations, defaultCalculation));
        }
    }
}
