namespace CarRental.Bookings.Entities
{
    public interface IVehicle
    {
        float DailyCost { get; set; }
        int Id { get; set; }
        string Make { get; set; }
        int Mileage { get; set; }
        string Model { get; set; }
        CarStyle Style { get; set; }
    }
}