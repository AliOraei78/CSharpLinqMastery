using System.Linq;
public static class ComplexQueries
{
    private static List<Person> _persons = DataGenerator.GeneratePersons();
    private static List<Department> _departments = DataGenerator.GenerateDepartment();

    public static IEnumerable<dynamic> GroupByCityWithCountAndAverageSalary() => 
            _persons.GroupBy(p => p.City)
            .Select(g => new
            {
                City = g.Key,
                Count = g.Count(),
                AverageSalary = g.Average(p => p.Salary)
            })
            .OrderByDescending(x => x.AverageSalary);

    public static IEnumerable<dynamic> GroupByCityWithHighestSalary() => 
        GroupByCityWithCountAndAverageSalary().Take(5);

    public static IEnumerable<dynamic> EmployeesWithDepartment() =>
        from p in _persons
        join d in _departments on p.Id equals d.ManagerId
        select new
        {
            EmployeeName = p.Name,
            Department = d.Name
        };

    public static IEnumerable<dynamic> AllEmployeesUnderManagers()
    {
        var managers = _persons.Where(p => _departments.Any(d => d.ManagerId == p.Id));
        return managers.SelectMany(m => _persons.Where(p => p.Id != m.Id)).Take(1000);
    }

    public static bool HasHighSalaryInAylaton() => _persons.Any(p => p.Salary > 150000 && p.City == "Aylaton");

    public static bool AllAdults() => _persons.All(p => p.Age >= 18);

    public static decimal TotalSalary() => _persons.Aggregate(0m, (total, p) => total + p.Salary);

    public static IEnumerable<string> DistinctCities() => _persons.Select(p => p.City).Distinct().Take(1000);

    public static IEnumerable<Person> PeopleUntilHighSalary() =>
        _persons.OrderBy(p => p.Salary)
        .TakeWhile(p => p.Salary <= 100000);

    public static IEnumerable<decimal> SalaryWithBonus()
    {
        var bonuses = new decimal[] { 5000, 10000, 15000, 20000, 25000 };
        return _persons.Take(5).Select(p => p.Salary).Zip(bonuses, (salary, bonus) => salary + bonus);
    }
}