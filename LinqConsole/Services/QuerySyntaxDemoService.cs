public class QuerySyntaxDemoService
{
    public void Run()
    {
        Console.WriteLine("=== Query Syntax Queries ===");

        var over50Query = QuerySyntaxQueries.GetAdultsOver50().Take(5).ToList(); 
        Console.WriteLine("Adults over 50:");
        foreach (var p in over50Query)
            Console.WriteLine($"{p.Name}, {p.Age}");
        Console.WriteLine("-------------\n");

        var sortedSalaryQuery = QuerySyntaxQueries.GetSortedBySalaryDescending().Take(5).ToList(); 
        Console.WriteLine("Top 5 by salary:");
        foreach (var ss in sortedSalaryQuery)
            Console.WriteLine($"{ss.Name}, {ss.Salary:C}");
        Console.WriteLine("-------------\n");

        var namesCitiesQuery = QuerySyntaxQueries.GetNamesAndCities().Take(5).ToList(); 
        Console.WriteLine("Names and cities top 5:");
        foreach (var nc in namesCitiesQuery)
            Console.WriteLine(nc);
        Console.WriteLine("-------------\n");

        var youngestQuery = QuerySyntaxQueries.GetTop10Youngest().ToList();
        Console.WriteLine("Top 10 yougnest:");
        foreach (var y in youngestQuery)
            Console.WriteLine($"{y.Name}, {y.Age}");
        Console.WriteLine("-------------\n");

        var highSalaryNYQuery = QuerySyntaxQueries.GetHighSalaryInNY().Take(5).ToList();
        Console.WriteLine("Top 10 by salary in nyc:");
        foreach (var hs in highSalaryNYQuery)
            Console.WriteLine($"{hs.Name}, {hs.Salary:C}");
        Console.WriteLine("-------------\n");
    }
}