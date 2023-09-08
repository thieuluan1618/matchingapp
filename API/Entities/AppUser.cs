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
}