namespace ServerManagement.Models;

internal sealed class Server
{
    public Server()
    {
        Random random = new();
        int randomNumber = random.Next(0, 2);
        IsOnline = randomNumber == 1 ? true : false;
    }

    public int ServerId { get; set; }
    public bool IsOnline { get; set; }
    public string? Name { get; set; }
    public string? City { get; set; }
}
