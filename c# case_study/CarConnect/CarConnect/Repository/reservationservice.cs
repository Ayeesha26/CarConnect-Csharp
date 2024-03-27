using System;
using System.Collections.Generic;

public interface IReservationService
{
    Reservation GetReservationById(int reservationId);
    List<Reservation> GetReservationsByCustomerId(int customerId);
    void CreateReservation(Reservation reservation);
    void UpdateReservation(Reservation reservation);
    void CancelReservation(int reservationId);
}

public class ReservationService : IReservationService
{
    private List<Reservation> reservations; // Assuming you have a list of reservations

    public ReservationService()
    {
        // Initialize reservations list
        reservations = new List<Reservation>();
    }

    public Reservation GetReservationById(int reservationId)
    {
        // Find and return reservation by ID
        return reservations.Find(r => r.ReservationID == reservationId);
    }

    public List<Reservation> GetReservationsByCustomerId(int customerId)
    {
        // Find and return reservations by customer ID
        return reservations.FindAll(r => r.CustomerID == customerId);
    }

    public void CreateReservation(Reservation reservation)
    {
        // Add reservation to the list
        reservations.Add(reservation);
    }

    public void UpdateReservation(Reservation reservation)
    {
        // Find reservation by ID and update information
        int index = reservations.FindIndex(r => r.ReservationID == reservation.ReservationID);
        if (index != -1)
        {
            reservations[index] = reservation;
        }
        else
        {
            throw new ArgumentException("Reservation not found", nameof(reservation));
        }
    }

    public void CancelReservation(int reservationId)
    {
        // Remove reservation by ID
        reservations.RemoveAll(r => r.ReservationID == reservationId);
    }
}