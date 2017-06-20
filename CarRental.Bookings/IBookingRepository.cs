using System.Collections.Generic;

namespace CarRental.Bookings
{
    public interface IBookingRepository
    {
        void AddBooking(Booking b);

        List<Booking> GetBookings();
    }
}