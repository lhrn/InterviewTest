using System.Collections.Generic;
using System.Linq;
using CarRental.Bookings.Entities;

namespace CarRental.Bookings.Validation
{
    public class NewBookingValidator
    {
        public bool CanBook(Booking booking, List<Booking> currentBookings) //TODO -> if 'currentBookings' gets to large, query only relevant bookings from a certain date
        {
            var clashingBookings = currentBookings
                .Where(b => b.CarId == booking.CarId
                            & b.ReturnDate.Date >= booking.RentalDate.Date
                            & b.RentalDate.Date <= booking.ReturnDate.Date)
                .ToList();

            return clashingBookings.Count == 0;
        }
    }
}
