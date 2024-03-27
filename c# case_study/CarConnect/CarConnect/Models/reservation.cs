using System;

public class Reservation
{
    // Properties
    public int ReservationID { get; set; }
    public int CustomerID { get; set; }
    public int VehicleID { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal TotalCost { get; private set; }
    public string Status { get; set; }

    // Constructor
    public Reservation(int reservationId, int customerId, int vehicleId, DateTime startDate,
                       DateTime endDate, string status)
    {
        ReservationID = reservationId;
        CustomerID = customerId;
        VehicleID = vehicleId;
        StartDate = startDate;
        EndDate = endDate;
        Status = status;
    }

    // Method to calculate total cost
    public void CalculateTotalCost(decimal dailyRate)
    {
        // Calculate duration of reservation
        TimeSpan duration = EndDate - StartDate;
        int numberOfDays = duration.Days;

        // Calculate total cost based on daily rate and duration
        TotalCost = dailyRate * numberOfDays;
    }
}
