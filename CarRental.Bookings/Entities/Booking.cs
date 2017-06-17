using CarRental.Bookings.Factory;
using CarRental.Bookings.Validation;

namespace CarRental.Bookings.Entities
{
    using System;

    public class Booking
    {
        public int CarId { get; set; }

        public string Name { get; set; }

        public float TotalCost { get; set; }

        public DateTime RentalDate { get; set; }

        public DateTime ReturnDate { get; set; }


        // N E W
        internal DateTime GetBookingCompleteDate(IVehicleMaintenanceProvider maintenanceProvider)
        {
            var daysRequired = maintenanceProvider.DaysRequired(CarId);

            return ReturnDate.AddDays(daysRequired).Date;
        }
    }
}