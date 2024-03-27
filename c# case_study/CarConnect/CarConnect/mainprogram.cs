using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Initialize services and dependencies
        ICustomerService customerService = new CustomerService();
        IVehicleService vehicleService = new VehicleService();
        IReservationService reservationService = new ReservationService();
        IAdminService adminService = new AdminService();

        // Initialize authentication service with dependencies
        AuthenticationService authService = new AuthenticationService(customerService, adminService);

        // Initialize report generator with data
        List<Reservation> reservations = new List<Reservation>(); // Retrieve reservations from somewhere
        List<Vehicle> vehicles = new List<Vehicle>(); // Retrieve vehicles from somewhere
        ReportGenerator reportGenerator = new ReportGenerator(reservations, vehicles);

        // Main menu loop
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Browse Vehicles");
            Console.WriteLine("4. Make a Reservation");
            Console.WriteLine("5. View Reports");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": // Login
                    Console.WriteLine("Login functionality...");
                    // Example usage of authentication service
                    authService.AuthenticateCustomer("username", "password"); // or authService.AuthenticateAdmin("username", "password");
                    break;
                case "2": // Register
                    Console.WriteLine("Registration functionality...");
                    // Example usage of customer service
                    customerService.RegisterCustomer(new Customer(1, "John", "Doe", "john@example.com", "1234567890", "Address", "username", "password", DateTime.Now));
                    break;
                case "3": // Browse Vehicles
                    Console.WriteLine("Browsing vehicles...");
                    // Example usage of vehicle service
                    vehicles = vehicleService.GetAvailableVehicles();
                    foreach (var vehicle in vehicles)
                    {
                        Console.WriteLine(vehicle);
                    }
                    break;
                case "4": // Make a Reservation
                    Console.WriteLine("Reservation functionality...");
                    // Example usage of reservation service
                    reservationService.CreateReservation(new Reservation(1, 1, 1, DateTime.Now, DateTime.Now.AddDays(1), "pending"));
                    break;
                case "5": // Exit
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}