using System.Collections.Generic;

namespace CarRental.Bookings.lib.Module
{
    public class GenericBookingRepository : BookingRepository
    {
        protected List<Booking> AllBookings = new List<Booking>();

        public override void AddCarBooking(Booking b)
        {
            AllBookings.Add(b);

            base.AddCarBooking(b);
        }

        public override void AddVanBooking(Booking b)
        {
            AllBookings.Add(b);

            base.AddVanBooking(b);
        }

        public override List<Booking> GetBookings()
        {
            return AllBookings;
        }

        public override void AddBooking(Booking b)
        {
            AllBookings.Add(b);
        }
    }
}
