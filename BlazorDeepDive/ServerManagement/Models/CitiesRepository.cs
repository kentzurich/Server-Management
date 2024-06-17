namespace ServerManagement.Models;

public static class CitiesRepository
{
    private static List<string> cities = new List<string>()
    {
        "Imus",
        "Dasmarinas",
        "Bacoor"
    };

    public static List<string> GetCities() => cities;
}
