namespace CarRental.Bookings
{
    using System.Collections.Generic;
    using CarRental.Bookings.Entities;

    public class BookingRepository
    {
        protected List<Booking> _cars = new List<Booking>();
        protected List<Booking> _vans = new List<Booking>();

        protected List<Booking> _bookings = new List<Booking>();

        public virtual List<Booking> GetCarBookings()
        {
            return _cars;
        }

        public virtual void AddCarBooking(Booking b)
        {
            this._cars.Add(b);
        }

        public virtual List<Booking> GetVanBookings()
        {
            return _vans;
        }

        public virtual void AddVanBooking(Booking b)
        {
            this._vans.Add(b);
        }

        public virtual List<Booking> GetBookings()
        {
            _bookings.AddRange(_cars);
            _bookings.AddRange(_vans);

            return _bookings;
        }

        public virtual void AddBooking(Booking b)
        {
            _bookings.Add(b);
        }
    }
}