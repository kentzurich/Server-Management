﻿namespace ServerManagement.Models;

public static class ServersRepository
{
    private static List<Server> servers = new List<Server>()
        {
            new Server {  Id = 1, Name = "Server1", City = "Imus" },
            new Server {  Id = 2, Name = "Server2", City = "Dasmarinas" },
            new Server {  Id = 3, Name = "Server3", City = "Bacoor" },
            new Server {  Id = 4, Name = "Server4", City = "Naic" },
            new Server {  Id = 5, Name = "Server5", City = "Noveleta" },
            new Server {  Id = 6, Name = "Server6", City = "Trece Martires" },
            new Server {  Id = 7, Name = "Server7", City = "General Trias" },
            new Server {  Id = 8, Name = "Server8", City = "Tagaytay" },
            new Server {  Id = 9, Name = "Server9", City = "Batangas" },
            new Server {  Id = 10, Name = "Server10", City = "Pasay" },
            new Server {  Id = 11, Name = "Server11", City = "Makati" },
            new Server {  Id = 12, Name = "Server12", City = "Taguig" },
            new Server {  Id = 13, Name = "Server13", City = "Paranaque" },
        };

    public static void AddServer(Server server)
    {
        var maxId = servers.Max(s => s.Id);
        server.Id = maxId + 1;
        servers.Add(server);
    }

    public static List<Server> GetServers() => servers;

    public static List<Server> GetServersByCity(string cityName)
    {
        return servers.Where(s => s.City!.Equals(cityName, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public static Server? GetServerById(int id)
    {
        var server = servers.FirstOrDefault(s => s.Id == id);
        if (server is not null)
        {
            return new Server
            {
                Id = server.Id,
                Name = server.Name,
                City = server.City,
                IsOnline = server.IsOnline
            };
        }

        return null;
    }

    public static void UpdateServer(int serverId, Server server)
    {
        if (serverId != server.Id) return;

        var serverToUpdate = servers.FirstOrDefault(s => s.Id == serverId);
        if (serverToUpdate is not null)
        {
            serverToUpdate.IsOnline = server.IsOnline;
            serverToUpdate.Name = server.Name;
            serverToUpdate.City = server.City;
        }
    }

    public static void DeleteServer(int serverId)
    {
        var server = servers.FirstOrDefault(s => s.Id == serverId);
        if (server is not null)
        {
            servers.Remove(server);
        }
    }

    public static List<Server> SearchServers(string serverFilter)
    {
        return servers.Where(s => s.Name!.Contains(serverFilter, StringComparison.OrdinalIgnoreCase)).ToList();
    }

}
