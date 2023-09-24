class Customer
{
    private static int NextCustomerID = 1;

    public int CustomerID { get; private set; }
    public string Task { get; set; }

    public Customer()
    {
        CustomerID = NextCustomerID++;
        Task = "DefaultTask"; // Initialize with a default value
    }
}