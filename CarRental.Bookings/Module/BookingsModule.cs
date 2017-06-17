using CarRental.Bookings.Calculator;
using CarRental.Bookings.Validation;

namespace CarRental.Bookings.Module
{
    public class BookingsModule
    {
        public static BookingService GetService()
        {
            return new BookingService(
                        new BookingRepository(), 
                        new NewBookingValidator(), 
                        new BookingFactory(), 
                        new CostCalculator());
        }
    }
}
