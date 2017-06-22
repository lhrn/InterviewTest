using Ploeh.AutoFixture.Xunit2;

namespace CarRental.Bookings.UnitTests.Utilities
{
    public class AutoMoqDataAttribute : AutoDataAttribute
    {
        public AutoMoqDataAttribute()
            : base(FixtureFactory.NewFixtureAutoMoq())
        {
        }
    }
}
