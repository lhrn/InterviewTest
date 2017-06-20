using System.Collections.Generic;

namespace CarRental.Bookings.lib.Module
{
    public class BookingRepository : IBookingRepository
    {
        protected List<Booking> Cars = new List<Booking>();
        protected List<Booking> Vans = new List<Booking>();

        protected List<Booking> Bookings = new List<Booking>();

        public virtual List<Booking> GetCarBookings()
        {
            return Cars;
        }

        public virtual void AddCarBooking(Booking b)
        {
            Cars.Add(b);
        }

        public virtual List<Booking> GetVanBookings()
        {
            return Vans;
        }

        public virtual void AddVanBooking(Booking b)
        {
            Vans.Add(b);
        }

        public virtual List<Booking> GetBookings()
        {
            Bookings.AddRange(Cars);
            Bookings.AddRange(Vans);

            return Bookings;
        }

        public virtual void AddBooking(Booking b)
        {
            Bookings.Add(b);
        }
    }
}