using System.Diagnostics;

public class BadQueriesDemoService
{
    public void Run()
    {
        Console.WriteLine("=== Test bad queries ===");

        Console.WriteLine("Get departments bad query: ");
        var stopwatch = Stopwatch.StartNew();
        long beforeMemory = GC.GetTotalMemory(true);
        var departments = BadQueries.GetDepartments();
        stopwatch.Stop();
        long memoryAfter = GC.GetTotalMemory(true);
        Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds}, Memory: {memoryAfter - beforeMemory}");
        Console.WriteLine("-----------------\n");

        Console.WriteLine("Join all bad query: ");
        stopwatch = Stopwatch.StartNew();
        beforeMemory = GC.GetTotalMemory(true);
        var joinAll = BadQueries.JoinAll();
        stopwatch.Stop();
        memoryAfter = GC.GetTotalMemory(true);
        Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds}, Memory: {memoryAfter - beforeMemory}");
        Console.WriteLine("-----------------\n");

        Console.WriteLine("Get by age bad query: ");
        stopwatch = Stopwatch.StartNew();
        beforeMemory = GC.GetTotalMemory(true);
        var getAge = BadQueries.GetByAgeDeffered();
        stopwatch.Stop();
        memoryAfter = GC.GetTotalMemory(true);
        Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds}, Memory: {memoryAfter - beforeMemory}");
        Console.WriteLine("-----------------\n");
    }
}