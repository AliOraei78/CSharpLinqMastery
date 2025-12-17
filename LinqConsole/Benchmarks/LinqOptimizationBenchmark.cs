using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

[MemoryDiagnoser]
public class LinqOptimizationBenchmark
{
    private static readonly List<Person> _persons = DataGenerator.GeneratePersons(100_000).ToList();
    private static readonly List<Department> _departments = DataGenerator.GenerateDepartments();

    [Benchmark]
    public void Bad_NPlus1()
    {
        var result = new List<string>();
        foreach (var p in _persons)
        {
            var dept = _departments.FirstOrDefault(d => d.ManagerId == p.Id);
            result.Add($"{p.Name} - {dept?.Name ?? "None"}");
        }
    }

    [Benchmark]
    public void Fixed_NPlus1()
    {
        var result = OptimizedQueries.GetDepartmentsOptimized().Take(1000).ToList();
    }

    [Benchmark]
    public void Bad_Cartesian()
    {
        var result = (from p in _persons from d in _departments select 1).Take(1000).ToList();
    }

    [Benchmark]
    public void Fixed_Cartesian()
    {
        var result = OptimizedQueries.JoinOptimized().Take(1000).ToList();
    }

    [Benchmark]
    public void Bad_PrematureToList()
    {
        var result = _persons.Where(p => p.Age > 30).ToList().OrderByDescending(p => p.Age).Take(100).ToList();
    }

    [Benchmark]
    public void Fixed_PrematureToList()
    {
        var result = OptimizedQueries.GetByAgeOptimized().ToList();
    }
}