using System.Linq;

public static class MethodSyntaxQueries
{
    private static List<Person> _persons = DataGenerator.GeneratePersons();

    public static IEnumerable<Person> GetAdultsOver50() => _persons.Where(p => p.Age > 50);

    public static IEnumerable<Person> GetSortedBySalaryDescending() => _persons.OrderByDescending(p => p.Salary);

    public static IEnumerable<string> GetNamesAndCities() => _persons.Select(p => $"{p.Name} - {p.City}");

    public static IEnumerable<Person> GetTop10Youngest() => _persons.OrderBy(p => p.Age).Take(10);

    public static IEnumerable<Person> GetHighSalaryInAylaton() => _persons.Where(p => p.City == "Aylaton" && p.Salary > 100000).OrderBy(p => p.Name);
}
