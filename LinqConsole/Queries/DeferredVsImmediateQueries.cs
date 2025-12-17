using System.Linq;

public static class DeferredVsImmediateQueries
{
    private static List<Person> _persons;

    public static void Initialize(List<Person> persons)
    {
        _persons = persons; 
    }

    public static IEnumerable<Person> Deferred_AdultsOver50() => _persons.Where(p => p.Age > 50);

    public static IEnumerable<Person> Deferred_SortedBySalary() => _persons.OrderByDescending(p => p.Salary);

    public static IEnumerable<string> Deferred_NamesAndCities() => _persons.Select(p => $"{p.Name} - {p.City}");

    public static IEnumerable<Person> Deferred_Top10Youngest() => _persons.OrderBy(p => p.Age).Take(10);

    public static IEnumerable<Person> Deferred_HighSalaryInTehran() => _persons.Where(p => p.Salary > 100000 && p.City == "New York");

    public static List<Person> Immediate_AdultsOver50() => _persons.Where(p => p.Age > 50).ToList();

    public static List<Person> Immediate_SortedBySalary() => _persons.OrderByDescending(p => p.Salary).ToList();

    public static List<string> Immediate_NamesAndCities() => _persons.Select(p => $"{p.Name} - {p.City}").ToList();

    public static List<Person> Immediate_Top10Youngest() => _persons.OrderBy(p => p.Age).Take(10).ToList();

    public static List<Person> Immediate_HighSalaryInTehran() => _persons.Where(p => p.Salary > 100000 && p.City == "New York").ToList();
}