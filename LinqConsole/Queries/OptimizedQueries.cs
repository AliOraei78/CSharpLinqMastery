using System.Linq;

public static class OptimizedQueries
{
    private static readonly List<Person> _persons = DataGenerator.GeneratePersons(100_000).ToList();
    private static readonly List<Department> _departments = DataGenerator.GenerateDepartments();

    public static IEnumerable<string> GetDepartmentsOptimized()
    {
        var lookup = _departments.ToLookup(d => d.ManagerId, d => d.Name);

        foreach (var p in _persons)
        {
            var deptName = lookup[p.Id].FirstOrDefault() ?? "None";
            yield return $"Name: {p.Name}, Department: {deptName}";
        }
    }

    public static IEnumerable<dynamic> JoinOptimized()
    {
        return from p in _persons
               join d in _departments on p.Id equals d.ManagerId
               select new
               {
                   Employee = p.Name,
                   Department = d.Name
               };
    }

    public static IEnumerable<Person> GetByAgeOptimized()
    {
        return _persons
            .Where(p => p.Age > 30)
            .OrderByDescending(p => p.Age)
            .Take(100);
    }
}