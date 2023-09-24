class Employee
{
    public string Name { get; set; }
    public string Task { get; set; }

    public Employee(string name, string task)
    {
        Name = name;
        Task = task;
    }

    public void PerformTask(Customer customer)
    {
        Console.WriteLine(Name + " is performing " + Task + " for customer " + customer.CustomerID);
        // Simulate the time required to perform the task here
        // For example, Thread.Sleep(taskTime) if using threads or a timer for simulation
    }
}