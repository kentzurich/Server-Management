using System.ComponentModel.DataAnnotations;

namespace ServerManagement.Models;

public sealed class Server
{
    public Server()
    {
        Random random = new();
        int randomNumber = random.Next(0, 2);
        IsOnline = randomNumber == 1 ? true : false;
    }

    public int Id { get; set; }
    public bool IsOnline { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string City { get; set; }
}
