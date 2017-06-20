namespace CarRental.Vehicles
{
    public class Van : VehicleBase
    {
        public new decimal DailyCost { get; set; }

        public WheelBase WheelBase { get; set; }
    }
}