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

        datasetGeneration.Run();
        querySyntaxDemoService.Run();
        methodSyntaxDemoService.Run();
        deferredVsImmediateDemoService.Run();
        complexQueriesDemoService.Run();
        */
        
       BadQueriesDemoService badQueriesDemoService = new BadQueriesDemoService();
        badQueriesDemoService.Run();

        Console.ReadKey();
    }
}