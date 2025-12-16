public class Program
{
    public static void Main(string[] args)
    {
        DatasetGeneration datasetGeneration = new DatasetGeneration();
        QuerySyntaxDemoService querySyntaxDemoService = new QuerySyntaxDemoService();
        MethodSyntaxDemoService methodSyntaxDemoService = new MethodSyntaxDemoService();

        datasetGeneration.Run();
        querySyntaxDemoService.Run();
        methodSyntaxDemoService.Run();


        Console.ReadKey();
    }
}