namespace Geempe.Domain.Entities;

public class User
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    public bool IsActive { get; private set; }

    public User(int id, string name, string email, string passwordHash)
    {
        Id = id;
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
        IsActive = true;
    }

    public void Deactivate()
    {
        IsActive = false;
    }
}