using CarRental.Bookings.Calculator;
using CarRental.Bookings.Exceptions;
using CarRental.Bookings.Factory;
using CarRental.Bookings.Validation;
using CarRental.Vehicles;

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
        private readonly BookingCostCalculator _bookingCostCalculator;

        public BookingService(BookingRepository repo, NewBookingValidator newBookingValidator, BookingFactory bookingFactory, 
            BookingCostCalculator bookingCostCalculator)
        {
            _repo = repo;
            _newBookingValidator = newBookingValidator;
            _bookingFactory = bookingFactory;
            _bookingCostCalculator = bookingCostCalculator;
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

            booking.TotalCost = _bookingCostCalculator.Calculate(vehicle, duration, discount, booking);

            _repo.AddBooking(booking);

            return booking;
        }
    }
}
