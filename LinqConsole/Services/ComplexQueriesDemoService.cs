public class ComplexQueriesDemoService
{
    public void Run()
    {
        Console.WriteLine("=== Complex LINQ Queries ===");
        Console.WriteLine("GroupBy city with count and average salary: ");
        foreach(var g in ComplexQueries.GroupByCityWithCountAndAverageSalary())
            Console.WriteLine($"City: {g.City}, Count: {g.Count}, Average salary: {g.AverageSalary:C}");
        Console.WriteLine("-------------\n");

        Console.WriteLine("GroupBy city with highest salary: ");
        foreach(var g in ComplexQueries.GroupByCityWithHighestSalary())
            Console.WriteLine($"City: {g.City}, Salary: {g.AverageSalary:C}");
        Console.WriteLine("-------------\n");

        Console.WriteLine("Join Employees with Person: ");
        foreach(var p in ComplexQueries.EmployeesWithDepartment())
            Console.WriteLine($"Name: {p.EmployeeName}, Department: {p.Department}");
        Console.WriteLine("-------------\n");

        Console.WriteLine("Join Employees with Person: ");
        foreach(var p in ComplexQueries.AllEmployeesUnderManagers())
            Console.WriteLine($"Name: {p.Name}");
        Console.WriteLine("-------------\n");

        Console.WriteLine($"Has high salary in Aylaton: {ComplexQueries.HasHighSalaryInAylaton()}");
        Console.WriteLine("-------------\n");

        Console.WriteLine($"TotalSalary: {ComplexQueries.TotalSalary()}");
        Console.WriteLine("-------------\n");

        Console.WriteLine("Distinct cities: ");
        foreach (var p in ComplexQueries.DistinctCities())
            Console.WriteLine($"City: {p}");
        Console.WriteLine("-------------\n");

        Console.WriteLine("Join Employees with Person: ");
        foreach (var p in ComplexQueries.PeopleUntilHighSalary())
            Console.WriteLine($"Name: {p.Name}, Salary: {p.Salary}");
        Console.WriteLine("-------------\n");

        Console.WriteLine("Salary With Bonus: ");
        foreach (var p in ComplexQueries.SalaryWithBonus())
            Console.WriteLine($"Salary: {p}");
        Console.WriteLine("-------------\n");
    }
}