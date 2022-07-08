public static class EmployeeRepo
{
    public static List<Employee> Employees
        = new List<Employee> {
                new (1, "Tayam", 8000),
                new (2, "Lilyan", 7500),
                new (3, "Mohamed", 8250),
                new (4, "Ahmed", 7800),
                new (5, "Mahmoud", 8500)
            };

    private static int GetNewId()
        => Employees.Max(e => e.Id) + 1;

    public static Employee Add(Employee employee)
    {
        employee.Id = GetNewId();
        Employees.Add(employee);
        return employee;
    }

    public static void Delete(int id)
        => Employees.Remove(Employees.FirstOrDefault(e => e.Id == id));

    public static Employee Update(Employee employee)
    {
        Employee emp = Employees.FirstOrDefault(e => e.Id == employee.Id);
        if (emp != null)
        {
            Employees.Remove(emp);
            Employees.Add(employee);
            return employee;
        }
        return null;
    }
}