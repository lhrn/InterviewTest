using System.Linq;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;

namespace CarRental.Bookings.UnitTests.Utilities
{
    public static class FixtureFactory
    {
        public static IFixture NewFixtureAutoMoq()
        {
            var fixture = new Fixture()
                .Customize(new AutoMoqCustomization());

            fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
                .ForEach(b => fixture.Behaviors.Remove(b));
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            return fixture;
        }
    }
}
