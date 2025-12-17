public class MethodSyntaxDemoService
{
    public void Run()
    {
        Console.WriteLine("=== Method Syntax Queries ===");

        var over50 = MethodSyntaxQueries.GetAdultsOver50().Take(5).ToList();
        Console.WriteLine("Adults over 50:");
        foreach (var p in over50)
            Console.WriteLine($"{p.Name}, {p.Age}");
        Console.WriteLine("-------------\n");

        var sortedSalary = MethodSyntaxQueries.GetSortedBySalaryDescending().Take(5).ToList();
        Console.WriteLine("Top 5 by salary:");
        foreach (var ss in sortedSalary)
            Console.WriteLine($"{ss.Name}, {ss.Salary:C}");
        Console.WriteLine("-------------\n");

        var namesCities = MethodSyntaxQueries.GetNamesAndCities().Take(5).ToList();
        Console.WriteLine("Names and cities top 5:");
        foreach (var nc in namesCities)
            Console.WriteLine(nc);
        Console.WriteLine("-------------\n");

        var youngest = MethodSyntaxQueries.GetTop10Youngest().Take(10).ToList();
        Console.WriteLine("Top 10 yougnest:");
        foreach (var y in youngest)
            Console.WriteLine($"{y.Name}, {y.Age}");
        Console.WriteLine("-------------\n");

        var highSalaryAylaton = MethodSyntaxQueries.GetHighSalaryInAylaton().Take(5).ToList();
        Console.WriteLine("Top 10 by salary in Aylaton:");
        foreach (var hs in highSalaryAylaton)
            Console.WriteLine($"{hs.Name}, {hs.Salary:C}");
        Console.WriteLine("-------------\n");
    }
}
