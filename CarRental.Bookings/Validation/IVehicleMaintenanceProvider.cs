namespace CarRental.Bookings.Validation
{
    public interface IVehicleMaintenanceProvider
    {
        int DaysRequired(int vehicleId);
    }
}