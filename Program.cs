using System;
using System.Globalization;
using SolSemInterface.Entities;
using SolSemInterface.Services;

namespace SolSemInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/mm/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Retunr (dd/mm/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Instanciando CarRental
            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            // Instanciando um Service RentalService
            RentalService rentalService = new RentalService(hour, day);

            // Processando o Invoice para CarRental
            rentalService.ProcessInvoice(carRental);
        }
    }
}
