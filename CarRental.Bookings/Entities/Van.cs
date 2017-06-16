namespace CarRental.Bookings.Entities
{
    public class Van : Car
    {
        public new decimal DailyCost { get; set; }

        public WheelBase WheelBase { get; set; }
    }
}