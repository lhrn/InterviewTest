namespace CarRental.Bookings
{
    using System.Collections.Generic;
    using CarRental.Bookings.Entities;

    public class BookingRepository
    {
        protected List<Booking> _cars = new List<Booking>();
        protected List<Booking> _vans = new List<Booking>();

        

        public List<Booking> GetCarBookings()
        {
            return _cars;
        }

        public virtual void AddCarBooking(Booking b)
        {
            this._cars.Add(b);
        }

        public List<Booking> GetVanBookings()
        {
            return _vans;
        }

        public virtual void AddVanBooking(Booking b)
        {
            this._vans.Add(b);
        }
    }
}