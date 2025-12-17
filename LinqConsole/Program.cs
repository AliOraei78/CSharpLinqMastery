using BenchmarkDotNet.Running;
using Bogus;

public class Program
{
    public static void Main(string[] args)
    {
        /*
        DatasetGeneration datasetGeneration = new DatasetGeneration();
        QuerySyntaxDemoService querySyntaxDemoService = new QuerySyntaxDemoService();
        MethodSyntaxDemoService methodSyntaxDemoService = new MethodSyntaxDemoService();
        DeferredVsImmediateDemoService deferredVsImmediateDemoService = new DeferredVsImmediateDemoService();
        ComplexQueriesDemoService complexQueriesDemoService = new ComplexQueriesDemoService();
        BadQueriesDemoService badQueriesDemoService = new BadQueriesDemoService();

        datasetGeneration.Run();
        querySyntaxDemoService.Run();
        methodSyntaxDemoService.Run();
        deferredVsImmediateDemoService.Run();
        complexQueriesDemoService.Run();
        badQueriesDemoService.Run();
        */

        var summary = BenchmarkRunner.Run<LinqOptimizationBenchmark>();

        Console.ReadKey();
    }
}