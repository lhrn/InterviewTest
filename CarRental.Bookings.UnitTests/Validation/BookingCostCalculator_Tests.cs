// ReSharper disable InconsistentNaming

using CarRental.Bookings.Pricing;
using CarRental.Bookings.Pricing.Calculations;
using CarRental.Bookings.UnitTests.Utilities;
using CarRental.Vehicles;
using Moq;
using Ploeh.AutoFixture.Xunit2;
using Xunit;

namespace CarRental.Bookings.UnitTests.Validation
{
    public class BookingCostCalculator_Tests
    {

        [Theory, AutoMoqData]
        public void Calculate_UsesDefaultCalculation_WhenNoneFound(CalculateParams p, float expectedCost, [Frozen]Mock<ICalculation> defaultCalculation, BookingCostCalculator sut)
        {
            defaultCalculation.Setup(_ => _.Run(p.Vehicle, p.Duration, p.Discount, p.Booking)).Returns(expectedCost);

            var cost = sut.Calculate(p.Vehicle, p.Duration, p.Discount, p.Booking);

            Assert.Equal(expectedCost, cost);
            defaultCalculation.Verify(_ => _.Run(p.Vehicle, p.Duration, p.Discount, p.Booking), Times.Exactly(1));
        }
    }

    #region helpers

    public class CalculateParams
    {
        public IVehicle Vehicle { get; set; }

        public int Duration { get; set; }

        public float Discount { get; set; }

        public Booking Booking { get; set; }
    }

    #endregion
}
