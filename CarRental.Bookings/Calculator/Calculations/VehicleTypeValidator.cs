using CarRental.Bookings.Entities;
using CarRental.Bookings.Exceptions;

namespace CarRental.Bookings.Calculator.Calculations
{
    public class VehicleTypeValidator<TTarget> where TTarget : class, IVehicle
    {
        protected TTarget CastToType<TSource>(TSource source, bool throwOnError = true) where TSource : IVehicle
        {
            var vehicle = source as TTarget;

            if (vehicle != null) return vehicle;

            if(throwOnError)
                throw new InvalidVehicleTypeException($"vehicle is not of expected type {typeof(TTarget)}");

            return null;
        }

        protected bool IsVehicleType<TType>(IVehicle vehicle) where TType : class, IVehicle
        {
            var isType = vehicle is TType;

            return isType;
        }
    }
}
