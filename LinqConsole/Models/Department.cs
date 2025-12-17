public class Department
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int ManagerId { get; set; }

    public Department()
    {

    }
    public Department(int id, string name, int mnagerId)
    {
        Id = id;
        Name = name;
        ManagerId = mnagerId;
    }
}