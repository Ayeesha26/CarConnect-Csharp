using System;
using System.Collections.Generic;

public interface IVehicleService
{
    Vehicle GetVehicleById(int vehicleId);
    List<Vehicle> GetAvailableVehicles();
    void AddVehicle(Vehicle vehicle);
    void UpdateVehicle(Vehicle vehicle);
    void RemoveVehicle(int vehicleId);
}

public class VehicleService : IVehicleService
{
    private List<Vehicle> vehicles; // Assuming you have a list of vehicles

    public VehicleService()
    {
        // Initialize vehicles list
        vehicles = new List<Vehicle>();
    }

    public Vehicle GetVehicleById(int vehicleId)
    {
        // Find and return vehicle by ID
        return vehicles.Find(v => v.VehicleID == vehicleId);
    }

    public List<Vehicle> GetAvailableVehicles()
    {
        // Filter and return available vehicles
        return vehicles.FindAll(v => v.Availability);
    }

    public void AddVehicle(Vehicle vehicle)
    {
        // Add vehicle to the list
        vehicles.Add(vehicle);
    }

    public void UpdateVehicle(Vehicle vehicle)
    {
        // Find vehicle by ID and update information
        int index = vehicles.FindIndex(v => v.VehicleID == vehicle.VehicleID);
        if (index != -1)
        {
            vehicles[index] = vehicle;
        }
        else
        {
            throw new ArgumentException("Vehicle not found", nameof(vehicle));
        }
    }

    public void RemoveVehicle(int vehicleId)
    {
        // Remove vehicle by ID
        vehicles.RemoveAll(v => v.VehicleID == vehicleId);
    }
}