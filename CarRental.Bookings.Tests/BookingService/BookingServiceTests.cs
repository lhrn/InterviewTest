using System;
using CarRental.Bookings.lib.Module;
using CarRental.Vehicles.Cars;
using CarRental.Vehicles.Vans;
using NUnit.Framework;

namespace CarRental.Bookings.Tests.BookingService
{
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

            //TODO -> make this a command(void)
            var booking = service.MakeCarBooking(car, DateTime.Today, 1, 0, "Joe Bloggs");

            Assert.AreEqual(100, booking.TotalCost);
        }

        [Test]
        public void agreed_discount_is_applied()
        {
            var service = BookingsModule.GetService();

            var car = new Car {DailyCost = 100};

            var booking = service.MakeCarBooking(car, DateTime.Now, 1, 20, "joe blogs");

            Assert.AreEqual(80, booking.TotalCost);

        }

        [Test]
        public void MakeCarBooking_GetsDiscountOf25Percent_WhenVanBooked_MoreThan5Days()
        {
            var service = BookingsModule.GetService();

            var van = new Van { DailyCost = 100 };

            var booking = service.MakeCarBooking(van, DateTime.Now, 6, 0, "joe blogs");

            Assert.AreEqual(450, booking.TotalCost);
        }


    }
}
