using CarRental.Bookings.lib.Exceptions;
using CarRental.Bookings.lib.Module;
using CarRental.Vehicles;
using CarRental.Vehicles.Cars;
using CarRental.Vehicles.Vans;

namespace CarRental
{
    using CarRental.Bookings;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            var bookingService = BookingsModule.GetService();

            Console.Out.WriteLine("Vehicle Rentals Ltd.");

            while (true)
            {
                PrintOptions();

                var input = Console.In.ReadLine();

                try
                {
                    IVehicle vehicle;

                    if (input == "1")
                    {
                        vehicle = GetCar();
                    }
                    else if (input == "2")
                    {
                        vehicle = GetVan();
                    }
                    else break;

                    bookingService.MakeCarBooking(vehicle, GetDate(), GetDuration(), GetDiscount(), GetName());
                }
                catch (CannotBookCarException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static void PrintOptions()
        {
            Console.Out.WriteLine("1. Make a car booking");
            Console.Out.WriteLine("2. Make a van booking");
            Console.Out.WriteLine("Enter your selection:");
        }

        #region Don't worry about this code unless you need to
        static Car GetCar()
        {
            Console.Out.WriteLine("Select Car:");
            var cars = new List<Car>
            {
                new Car { Id = 1, Make = "Ford", Model = "Focus", DailyCost = 80, Mileage = 11000, Style = CarStyle.HatchBack },
                new Car { Id = 2, Make = "Honda", Model = "Civic", DailyCost = 80, Mileage = 12000, Style = CarStyle.HatchBack },
                new Car { Id = 3, Make = "Seat", Model = "Leon", DailyCost = 80, Mileage = 13000, Style = CarStyle.HatchBack },
                new Car { Id = 4, Make = "BMW", Model = "3 Series", DailyCost = 100, Mileage = 14000, Style = CarStyle.Saloon }
            };
            int idx = 1;
            cars.ForEach(c => Console.Out.WriteLine("{0}: {1} {2}", idx++, c.Make, c.Model));

            var input = int.Parse(Console.In.ReadLine());

            return cars.ElementAt(input - 1);
        }

        static Van GetVan()
        {
            Console.Out.WriteLine("Select Van:");
            var vans = new List< Van>
            {
                new Van { Id = 5, Make = "Merc", Model = "Sprinter", DailyCost = 150, Mileage = 11000, WheelBase = WheelBase.Short },
                new Van { Id = 6, Make = "Ford", Model = "Transit", DailyCost = 150, Mileage = 12000, WheelBase = WheelBase.Short },
                new Van { Id = 7, Make = "Renault", Model = "Box", DailyCost = 160, Mileage = 13000, WheelBase = WheelBase.Long },
                new Van { Id = 8, Make = "Toyota", Model = "Toyota Van", DailyCost = 200, Mileage = 14000, WheelBase = WheelBase.Long }
            };
            int idx = 1;
            vans.ForEach(v => Console.Out.WriteLine("{0}: {1} {2}", idx++, v.Make, v.Model));

            var input = int.Parse(Console.In.ReadLine());

            return vans.ElementAt(input - 1);
        }

        static DateTime GetDate() {
            Console.Out.WriteLine("Enter date (yyyy-MM-dd):");
            var input = Console.In.ReadLine();
            DateTime dt = DateTime.ParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            return dt;
        }

        static int GetDuration()
        {
            Console.Out.WriteLine("Enter duration:");
            return int.Parse(Console.In.ReadLine());
        }

        static float GetDiscount()
        {
            Console.Out.WriteLine("Any discount to apply (0 for none):");
            return float.Parse(Console.In.ReadLine());
        }

        static string GetName()
        {
            Console.Out.WriteLine("Enter customer name:");
            return Console.In.ReadLine();
        }
        #endregion
    }
}
