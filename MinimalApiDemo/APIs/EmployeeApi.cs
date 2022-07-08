public static class EmployeeApi
{
    public static void MapEmployeeApi(this WebApplication app)
    {
        app.MapGet("/api/employees", (IEmployeeService employeeService) 
            => employeeService.GetEmployees());

        app.MapGet("/api/employees/{id}", (IEmployeeService employeeService, int id) 
            => employeeService.GetById(id) is Employee employee ? Results.Ok(employee) : Results.NotFound());

        app.MapPost("/api/employees", (IEmployeeService employeeService, Employee employee) 
            => employeeService.Add(employee) is Employee addedEmployee ? Results.Ok(addedEmployee) : Results.BadRequest());

        app.MapPut("/api/employees", (IEmployeeService employeeService, Employee employee)
           => employeeService.Update(employee) is Employee updatedEmployee ? Results.Ok(updatedEmployee) : Results.BadRequest());

        app.MapDelete("/api/employees/{id}", (IEmployeeService employeeService, int id) => {
            employeeService.Delete(id);
        });
    }
}