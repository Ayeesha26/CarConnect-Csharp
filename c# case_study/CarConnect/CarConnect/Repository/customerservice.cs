using System;
using System.Collections.Generic;

public interface ICustomerService
{
    Customer GetCustomerById(int customerId);
    Customer GetCustomerByUsername(string username);
    void RegisterCustomer(Customer customer);
    void UpdateCustomer(Customer customer);
    void DeleteCustomer(int customerId);
}

public class CustomerService : ICustomerService
{
    private List<Customer> customers; 

    public CustomerService()
    {
        // Initialize customers list
        customers = new List<Customer>();
    }

    public Customer GetCustomerById(int customerId)
    {
        // Find and return customer by ID
        return customers.Find(c => c.CustomerID == customerId);
    }

    public Customer GetCustomerByUsername(string username)
    {
        // Find and return customer by username
        return customers.Find(c => c.Username == username);
    }

    public void RegisterCustomer(Customer customer)
    {
        // Add customer to the list
        customers.Add(customer);
    }

    public void UpdateCustomer(Customer customer)
    {
        // Find customer by ID and update information
        int index = customers.FindIndex(c => c.CustomerID == customer.CustomerID);
        if (index != -1)
        {
            customers[index] = customer;
        }
        else
        {
            throw new ArgumentException("Customer not found", nameof(customer));
        }
    }

    public void DeleteCustomer(int customerId)
    {
        // Remove customer by ID
        customers.RemoveAll(c => c.CustomerID == customerId);
    }
}