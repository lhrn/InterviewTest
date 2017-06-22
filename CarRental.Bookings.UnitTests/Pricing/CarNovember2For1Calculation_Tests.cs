// ReSharper disable InconsistentNaming

using System;
using CarRental.Bookings.Pricing.Calculations.Cars;
using CarRental.Bookings.UnitTests.Utilities;
using CarRental.Vehicles;
using CarRental.Vehicles.Cars;
using Ploeh.AutoFixture;
using Xunit;

namespace CarRental.Bookings.UnitTests.Pricing
{
    public class CarNovember2For1Calculation_Tests
    {

        [Fact]
        public void NO_DiscountApplied_When_Month_ISNOT_November()
        {
            var fixture = FixtureFactory.NewFixtureAutoMoq();

            //arrange
            var p = fixture.Create<CalcParams>();

            p.Vehicle = new Car { DailyCost = 100, Style = CarStyle.SUV };
            p.Booking.RentalDate = new DateTime(1990, 1, 1);

            var baseCalc = new CarCalculation();
            var expected = baseCalc.Run(p.Vehicle, p.Duration, p.Discount, p.Booking);

            //act
            var sut = fixture.Create<CarNovember2For1Calculation>();

            var result = sut.Run(p.Vehicle, p.Duration, p.Discount, p.Booking);

            //assert
            Assert.Equal(expected, result);
        }
    }

    #region helpers

    public class CalcParams
    {
        public IVehicle Vehicle { get; set; }

        public int Duration { get; set; }

        public float Discount { get; set; }

        public Booking Booking { get; set; }
    }

    #endregion
}
