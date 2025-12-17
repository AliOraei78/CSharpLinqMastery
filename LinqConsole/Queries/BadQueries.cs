public static class BadQueries
{
    private static List<Person> _persons = DataGenerator.GeneratePersons();
    private static List<Department> _departments = DataGenerator.GenerateDepartments();

    public static List<string> GetDepartments()
    {
        var result = new List<string>();

        foreach (var p in _persons)
        {
            var dept = _departments.FirstOrDefault(d => d.ManagerId == p.Id);
            if (dept != null)
            {
                result.Add($"Name: {p.Name}, Department: {dept.Name}");
            }
        }
        return result;
    }

    public static IEnumerable<dynamic> JoinAll() => from p in _persons
                                                             from d in _departments
                                                             select new
                                                             {
                                                                Employee = p.Name,
                                                                Department = d.Name
                                                             };

    public static IEnumerable<dynamic> GetByAgeToList() => 
        _persons.Where(p => p.Age > 30)
        .ToList()
        .OrderByDescending(p => p.Age);
}