namespace CarRental.Vehicles.lib
{
    public interface IVehicleMaintenanceProvider
    {
        int DaysRequired(int vehicleId);
    }
}