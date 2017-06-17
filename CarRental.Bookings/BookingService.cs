using CarRental.Bookings.Calculator;
using CarRental.Bookings.Exceptions;
using CarRental.Bookings.Factory;
using CarRental.Bookings.Validation;

namespace CarRental.Bookings
{
    using System;
    using Entities;

    public class BookingService
    {
        #region init

        private readonly BookingRepository _repo;
        private readonly NewBookingValidator _newBookingValidator;
        private readonly BookingFactory _bookingFactory;
        private readonly CostCalculator _costCalculator;

        public BookingService(BookingRepository repo, NewBookingValidator newBookingValidator, BookingFactory bookingFactory, 
            CostCalculator costCalculator)
        {
            _repo = repo;
            _newBookingValidator = newBookingValidator;
            _bookingFactory = bookingFactory;
            _costCalculator = costCalculator;
        }

        #endregion


        public Booking MakeCarBooking(IVehicle vehicle, DateTime start, int duration, float discount, string name)
        {
            var booking = _bookingFactory.NewBooking(vehicle, start, duration, name);

            var currentBookings = _repo.GetBookings();

            // check for clashes

            var canBook = _newBookingValidator.CanBook(booking, currentBookings);

            if (canBook == false)
                throw CannotBookCarException.New(booking);

            // calculate 

            booking.TotalCost = _costCalculator.Calculate(vehicle, duration, discount);

            _repo.AddBooking(booking);

            return booking;
        }
    }
}
