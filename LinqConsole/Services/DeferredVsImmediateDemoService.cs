public class DeferredVsImmediateDemoService
{
    public void Run()
    {

        var persons = DataGenerator.GeneratePersons(100_000);
        Console.WriteLine("=== Deferred Execution Test ===");
        var query = persons.Where(p => p.Age > 50);

        Console.WriteLine($"Count before increase: {query.Count()}");
        persons.Add(new Person(100001, "New", 323223));
        Console.WriteLine($"Count after increase: {query.Count()}");
        foreach (var p in query.Take(10))
            Console.WriteLine($"{p.Id}, {p.Age}");

        Console.WriteLine("=== Immediate Execution Test ===");
        var query1 = persons.Where(p => p.Age > 50).ToList();
        Console.WriteLine($"Count before increase: {query1.Count()}");
        persons.Add(new Person(100002, "New1", 2343));
        Console.WriteLine($"Count after increase: {query1.Count()}");

        foreach (var p in query.Take(10))
            Console.WriteLine($"{p.Id}, {p.Age}");

        Console.WriteLine("=== Deferred vs Immediate Execution ===");
        var people = DataGenerator.GeneratePersons(100_000).ToList();
        DeferredVsImmediateQueries.Initialize(people);

        var deferredQuery = DeferredVsImmediateQueries.Deferred_AdultsOver50();
        Console.WriteLine($"Count before increase: {deferredQuery.Count()}");
        people.Add(new Person(100004, "New2", 4444444));
        Console.WriteLine($"Count after increase: {deferredQuery.Count()}");

        var immediateQuery = DeferredVsImmediateQueries.Immediate_AdultsOver50();
        Console.WriteLine($"Count before increase: {immediateQuery.Count()}");
        people.Add(new Person(100005, "New3", 333333));
        Console.WriteLine($"Count after increase: {immediateQuery.Count()}");

        Console.WriteLine("\n=== Heavy query(group) ===");
        var deferredGroup = people.GroupBy(p => p.Age);
        var group25Deferred = deferredGroup.FirstOrDefault(g => g.Key == 25);
        Console.WriteLine($"Age 25 in deferred(before): {group25Deferred?.Count() ?? 0}");
        people.Add(new Person(100006, "New4", 25));
        group25Deferred = deferredGroup.FirstOrDefault(g => g.Key == 25);
        Console.WriteLine($"Age 25 in deferred(after): {group25Deferred?.Count() ?? 0}");

        var immediateGroup = people.GroupBy(p => p.Age).ToList();
        var group25Imemediate = immediateGroup.FirstOrDefault(g => g.Key == 25);
        Console.WriteLine($"Age 25 in Immediate(before): {group25Imemediate?.Count() ?? 0}");
        people.Add(new Person(100007, "New5", 25));
        group25Imemediate = immediateGroup.FirstOrDefault(g => g.Key == 25);
        Console.WriteLine($"Age 25 in Immediate(after): {group25Imemediate?.Count() ?? 0}");

        Console.ReadKey();
    }
}