public class Vehicle
{
    // Properties
    public int VehicleID { get; set; }
    public string Model { get; set; }
    public string Make { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public string RegistrationNumber { get; set; }
    public bool Availability { get; set; }
    public decimal DailyRate { get; set; }

    // Constructor
    public Vehicle(int vehicleId, string model, string make, int year, string color,
                   string registrationNumber, bool availability, decimal dailyRate)
    {
        VehicleID = vehicleId;
        Model = model;
        Make = make;
        Year = year;
        Color = color;
        RegistrationNumber = registrationNumber;
        Availability = availability;
        DailyRate = dailyRate;
    }
}