using System;
using CarRental.Vehicles.lib;

namespace CarRental.Bookings
{
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