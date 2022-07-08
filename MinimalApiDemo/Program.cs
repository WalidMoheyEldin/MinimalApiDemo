WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IEmployeeService, EmployeeService>();

WebApplication app = builder.Build();

app.MapGet("/", (HttpContext http) 
    => $".NET 6 Minimal Api Demo! => {http.Request.Scheme}://{http.Request.Host.Value}/api/Employees");

app.MapEmployeeApi();

app.Run();
