using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Bookings.Entities;

namespace CarRental.Bookings
{
    public class GenericBookingRepository : BookingRepository
    {
        protected List<Booking> _allBookings = new List<Booking>();

        public override void AddCarBooking(Booking b)
        {
            _allBookings.Add(b);

            base.AddCarBooking(b);
        }

        public override void AddVanBooking(Booking b)
        {
            _allBookings.Add(b);

            base.AddVanBooking(b);
        }

        public List<Booking> GetBookings()
        {
            return _allBookings;
        }
    }
}
