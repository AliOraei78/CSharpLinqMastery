public class DatasetGeneration
{
    public void Run()
    {
        Console.WriteLine("Generating dataset...");
        var persons = DataGenerator.GeneratePersons(100_000);

        Console.WriteLine($"Count: {persons.Count}");
        Console.WriteLine($"First 10:");

        foreach (var person in persons)
            Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Age: {person.Age}, City: {person.City}, Salary: {person.Salary}");
        Console.WriteLine("Dataset is ready");
        Console.WriteLine("-------------\n");
    }
}