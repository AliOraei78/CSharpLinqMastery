using Bogus;

public class Program
{
    public static void Main(string[] args)
    {
        DatasetGeneration datasetGeneration = new DatasetGeneration();
        QuerySyntaxDemoService querySyntaxDemoService = new QuerySyntaxDemoService();
        MethodSyntaxDemoService methodSyntaxDemoService = new MethodSyntaxDemoService();
        DeferredVsImmediateDemoService deferredVsImmediateDemoService = new DeferredVsImmediateDemoService();

        datasetGeneration.Run();
        querySyntaxDemoService.Run();
        methodSyntaxDemoService.Run();
        deferredVsImmediateDemoService.Run();

        Console.ReadKey();
    }
}