namespace CarRental.Bookings.Entities
{
    public interface IVehicle
    {
        int Id { get; set; }
        float DailyCost { get; set; }
        string Make { get; set; }
        int Mileage { get; set; }
        string Model { get; set; }
    }
}