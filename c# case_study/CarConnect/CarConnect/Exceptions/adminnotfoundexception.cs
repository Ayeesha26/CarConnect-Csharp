using System;

public class AdminNotFoundException : Exception
{
    public AdminNotFoundException() { }

    public AdminNotFoundException(string message)
        : base(message) { }

    public AdminNotFoundException(string message, Exception innerException)
        : base(message, innerException) { }
}
