namespace ServerlessAPI.Entities;

public class User
{
    public Guid Id { get; set; } = Guid.Empty;
    public string Name { get; set; } = string.Empty;
}
