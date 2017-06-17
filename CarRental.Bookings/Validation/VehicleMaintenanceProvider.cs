using System.Collections.Generic;
using CarRental.Bookings.Factory;

namespace CarRental.Bookings.Validation
{
    public class VehicleMaintenanceProvider : IVehicleMaintenanceProvider
    {
        #region init

        private readonly Dictionary<int, int> _register;

        public VehicleMaintenanceProvider()
        {
            _register = GetRegister();
        }

        private Dictionary<int, int> GetRegister()
        {
            //TODO -> get from config file

            return new Dictionary<int, int>
            {
                {1, 1},
                {2, 1},
                {3, 1},
                {4, 1},
                {5, 0},
                {6, 0},
                {7, 0},
                {8, 0},
            };
        }

        #endregion

        public int DaysRequired(int vehicleId)
        {
            if (_register.ContainsKey(vehicleId) == false) return 0;

            return _register[vehicleId];
        }
    }
}