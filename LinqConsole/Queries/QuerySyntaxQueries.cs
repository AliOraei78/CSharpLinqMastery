using Microsoft.Diagnostics.Tracing.Parsers;
using System.Linq;

public static class QuerySyntaxQueries
{
    private static readonly List<Person> _persons = DataGenerator.GeneratePersons();

    public static IEnumerable<Person> GetAdultsOver50() => from p in _persons 
                                                           where p.Age > 50 
                                                           select p;

    public static IEnumerable<Person> GetSortedBySalaryDescending() => from p in 
                                                                       _persons orderby p.Salary 
                                                                       descending select p;

    public static IEnumerable<string> GetNamesAndCities() => from p in _persons 
                                                             select $"{p.Name} - {p.City}";

    public static IEnumerable<Person> GetTop10Youngest() => (from p in _persons
                                                            orderby p.Age
                                                            select p).Take(10);

    public static IEnumerable<Person> GetHighSalaryInAylaton() => from p in _persons
                                                             where p.Salary > 100000 && p.City == "Aylaton"
                                                             orderby p.Name
                                                             select p;
}