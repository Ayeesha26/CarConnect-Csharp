using System;
using System.Collections.Generic;
using System.Linq;

public class ReportGenerator
{
    private readonly List<Reservation> _reservations;
    private readonly List<Vehicle> _vehicles;

    public ReportGenerator(List<Reservation> reservations, List<Vehicle> vehicles)
    {
        _reservations = reservations;
        _vehicles = vehicles;
    }

    // Generate a report of reservations for a specific vehicle
    public void GenerateReservationReportForVehicle(int vehicleId)
    {
        Console.WriteLine($"Reservation Report for Vehicle ID: {vehicleId}");

        var reservationsForVehicle = _reservations.Where(r => r.VehicleID == vehicleId);

        foreach (var reservation in reservationsForVehicle)
        {
            Console.WriteLine($"Reservation ID: {reservation.ReservationID}, Customer ID: {reservation.CustomerID}, Start Date: {reservation.StartDate}, End Date: {reservation.EndDate}, Total Cost: {reservation.TotalCost}, Status: {reservation.Status}");
        }
    }

    // Generate a report of available vehicles
    public void GenerateAvailableVehiclesReport()
    {
        Console.WriteLine("Available Vehicles Report:");

        var availableVehicles = _vehicles.Where(v => v.Availability);

        foreach (var vehicle in availableVehicles)
        {
            Console.WriteLine($"Vehicle ID: {vehicle.VehicleID}, Make: {vehicle.Make}, Model: {vehicle.Model}, Year: {vehicle.Year}, Color: {vehicle.Color}, Daily Rate: {vehicle.DailyRate}");
        }
    }
}