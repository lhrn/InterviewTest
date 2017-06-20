using System.Collections.Generic;

namespace CarRental.Bookings.lib.Validation
{
    public interface INewBookingValidator
    {
        bool CanBook(Booking booking, List<Booking> currentBookings);
    }
}