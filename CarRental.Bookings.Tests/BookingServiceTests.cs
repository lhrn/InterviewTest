using CarRental.Bookings.Module;
using CarRental.Vehicles;

namespace CarRental.Bookings.Tests
{
    using System;
    using CarRental.Bookings.Entities;
    using NUnit.Framework;

    [TestFixture]
    public class BookingServiceTests
    {
        [Test]
        public void when_making_a_car_booking_it_should_calculate_the_daily_rate()
        {
            var service = BookingsModule.GetService();

            var car = new Car {DailyCost = 100};

            var booking = service.MakeCarBooking(car, DateTime.Today, 1, 0, "Joe Bloggs");
            Assert.AreEqual(100, booking.TotalCost);
        }

        [Test]
        public void the_return_date_is_calculated_correctly()
        {
            var service = BookingsModule.GetService();

            var car = new Car {DailyCost = 100};

            var booking = service.MakeCarBooking(car, DateTime.Today, 1, 0, "Joe Bloggs");
            Assert.AreEqual(100, booking.TotalCost);
        }

        [Test]
        public void agreed_discount_is_applied()
        {
            
        }
    }
}
