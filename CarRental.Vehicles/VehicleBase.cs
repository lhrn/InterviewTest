namespace CarRental.Vehicles
{
    public class VehicleBase : IVehicle
    {
        public int Id { get; set; }

        public string Make { get; set; }

        public int Mileage { get; set; }

        public string Model { get; set; }

        public virtual float DailyCost { get; set; }
    }
}