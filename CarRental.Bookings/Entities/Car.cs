namespace CarRental.Bookings.Entities
{
    public class Car : IVehicle
    {
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public virtual float DailyCost { get; set; }

        public int Mileage { get; set; }


        #region r

        public CarStyle Style { get; set; }

        #endregion
    }
}