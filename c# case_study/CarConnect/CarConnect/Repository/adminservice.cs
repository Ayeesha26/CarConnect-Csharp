using System;
using System.Collections.Generic;

public interface IAdminService
{
    Admin GetAdminById(int adminId);
    Admin GetAdminByUsername(string username);
    void RegisterAdmin(Admin admin);
    void UpdateAdmin(Admin admin);
    void DeleteAdmin(int adminId);
}

public class AdminService : IAdminService
{
    private List<Admin> admins; // Assuming you have a list of admins

    public AdminService()
    {
        // Initialize admins list
        admins = new List<Admin>();
    }

    public Admin GetAdminById(int adminId)
    {
        // Find and return admin by ID
        return admins.Find(a => a.AdminID == adminId);
    }

    public Admin GetAdminByUsername(string username)
    {
        // Find and return admin by username
        return admins.Find(a => a.Username == username);
    }

    public void RegisterAdmin(Admin admin)
    {
        // Add admin to the list
        admins.Add(admin);
    }

    public void UpdateAdmin(Admin admin)
    {
        // Find admin by ID and update information
        int index = admins.FindIndex(a => a.AdminID == admin.AdminID);
        if (index != -1)
        {
            admins[index] = admin;
        }
        else
        {
            throw new ArgumentException("Admin not found", nameof(admin));
        }
    }

    public void DeleteAdmin(int adminId)
    {
        // Remove admin by ID
        admins.RemoveAll(a => a.AdminID == adminId);
    }
}