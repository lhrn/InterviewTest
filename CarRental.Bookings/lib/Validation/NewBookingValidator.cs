using System.Collections.Generic;
using System.Linq;
using CarRental.Vehicles.lib;

namespace CarRental.Bookings.lib.Validation
{
    public class NewBookingValidator : INewBookingValidator
    {
        #region init

        private readonly IVehicleMaintenanceProvider _maintenanceProvider;

        public NewBookingValidator(IVehicleMaintenanceProvider maintenanceProvider)
        {
            _maintenanceProvider = maintenanceProvider;
        }

        #endregion

        public bool CanBook(Booking booking, List<Booking> currentBookings)
        {
            var maintenanceDate = booking.GetBookingCompleteDate(_maintenanceProvider);

            var clashingBookings = currentBookings
                .Where(b => b.CarId == booking.CarId
                            & b.ReturnDate.Date >= booking.RentalDate.Date
                            & b.RentalDate.Date <= maintenanceDate)
                .ToList();

            return clashingBookings.Count == 0;
        }
    }
}
