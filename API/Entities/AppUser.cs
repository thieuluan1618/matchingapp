using API.Extensions;

namespace API.Entities;

public class AppUser
{
    public AppUser(string userName, byte[] passwordHash, byte[] passwordSalt)
    {
        UserName = userName;
        PasswordHash = passwordHash;
        PasswordSalt = passwordSalt;
    }

    public int Id { get; set; }

    public string UserName { get; set; }

    public byte[] PasswordHash { get; set; }

    public byte[] PasswordSalt { get; set; }

    public DateTime DateOfBird { get; set; }

    public string KnownAs { get; set; }

    public DateTime LastActive { get; set; }

    public DateTime Created { get; set; }
    public string Gender { get; set; }
    public string Introduction { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public ICollection<Photo> Photos { get; set; }

    public int GetAge()
    {
        return DateOfBird.CalculateAge();
    }
}