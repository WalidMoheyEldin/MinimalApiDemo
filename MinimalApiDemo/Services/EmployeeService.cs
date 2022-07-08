public interface IEmployeeService
{
    IEnumerable<Employee> GetEmployees();
    Employee GetById(int id);
    void Delete(int id);
    Employee Add(Employee employee);
    Employee Update(Employee employee);
}

public class EmployeeService : IEmployeeService
{
    public Employee Add(Employee employee)
        => EmployeeRepo.Add(employee);

    public Employee Update(Employee employee)
        => EmployeeRepo.Update(employee);

    public void Delete(int id)
        => EmployeeRepo.Delete(id);

    public Employee GetById(int id)
        => EmployeeRepo.Employees.FirstOrDefault(e => e.Id == id);

    public IEnumerable<Employee> GetEmployees() => EmployeeRepo.Employees.OrderBy(e => e.Id);
}