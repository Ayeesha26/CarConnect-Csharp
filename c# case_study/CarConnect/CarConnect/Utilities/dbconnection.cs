using System;
using Microsoft.Data.SqlClient;

public static class dbconnection
{
    // Method to establish a connection to the SQL Server database
    public static SqlConnection GetSqlConnection()
    {
        // Connection string with necessary information to connect to the database
        string connectionString = "Server=DESKTOP-RIQ1MAN;Database=CarConnect;Integrated Security=true;";

        // Create and return a new SqlConnection object
        return new SqlConnection(connectionString);
    }

    // Method to execute SQL queries
    public static void ExecuteSqlCommand(string query)
    {
        // Get connection
        using (SqlConnection connection = GetSqlConnection())
        {
            try
            {
                // Open connection
                connection.Open();

                // Create SqlCommand object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute query
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine("Error executing SQL command: ");
            }
            finally
            {
                // Close connection
                connection.Close();
            }
        }
    }
}
