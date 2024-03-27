public class AuthenticationService
{
    private readonly ICustomerService _customerService;
    private readonly IAdminService _adminService;

    public AuthenticationService(ICustomerService customerService, IAdminService adminService)
    {
        _customerService = customerService;
        _adminService = adminService;
    }

    // Authenticate customer
    public bool AuthenticateCustomer(string username, string password)
    {
        Customer customer = _customerService.GetCustomerByUsername(username);

        if (customer != null)
        {
            return customer.Authenticate(password);
        }

        return false;
    }

    // Authenticate admin
    public bool AuthenticateAdmin(string username, string password)
    {
        Admin admin = _adminService.GetAdminByUsername(username);

        if (admin != null)
        {
            return admin.Authenticate(password);
        }

        return false;
    }
}