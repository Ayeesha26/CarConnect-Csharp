using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class DatabaseContext : DbContext
{
    // Define DbSet for each entity (Customer, Vehicle, Reservation, Admin)
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Admin> Admins { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configure your database connection here
        optionsBuilder.UseSqlServer("Server=DESKTOP-RIQ1MAN;Database=CarConnect;Integrated Security=true;");
    }
}
