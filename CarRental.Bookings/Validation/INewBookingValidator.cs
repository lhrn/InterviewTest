using System.Collections.Generic;
using CarRental.Bookings.Entities;

namespace CarRental.Bookings.Validation
{
    public interface INewBookingValidator
    {
        bool CanBook(Booking booking, List<Booking> currentBookings);
    }
}