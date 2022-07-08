public record Employee
{
    public Employee(int id, string name, decimal salary)
    {
        this.Id = id;
        this.Name = name;
        this.Salary = salary;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
}