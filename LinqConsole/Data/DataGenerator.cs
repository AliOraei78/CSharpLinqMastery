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

    public static List<Department> GenerateDepartments()
    {
        return new List<Department>
    {
        new Department { Id = 1, Name = "Engineering", ManagerId = 3 },
        new Department { Id = 2, Name = "Sales", ManagerId = 5 },
        new Department { Id = 3, Name = "Marketing", ManagerId = 8 },
        new Department { Id = 4, Name = "HR", ManagerId = 12 },
        new Department { Id = 5, Name = "Finance", ManagerId = 15 },
        new Department { Id = 6, Name = "IT", ManagerId = 20 },
        new Department { Id = 7, Name = "Support", ManagerId = 25 },
        new Department { Id = 8, Name = "R&D", ManagerId = 30 },
        new Department { Id = 9, Name = "Operations", ManagerId = 35 },
        new Department { Id = 10, Name = "Legal", ManagerId = 40 }
    };
    }

}