using Bogus;

public static class DataGenerator
{
    public static List<Person> GeneratePersons(int count = 100_000) 
    {
        var faker = new Faker<Person>()
            .RuleFor(p => p.Id, f => f.IndexFaker + 1)
            .RuleFor(p => p.Name, f => f.Name.FullName())
            .RuleFor(p => p.Age, f => f.Random.Int(18, 80))
            .RuleFor(p => p.City, f => f.Address.City())
            .RuleFor(p => p.Salary, f => f.Random.Decimal(30000, 200000));

        return faker.Generate(count);
            
    }
}