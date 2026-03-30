namespace AppointCare.Infrastructure.Helpers;

public static class DbPathHelper
{
    public static string GetDatabasePath()
    {
        var folder = Environment.GetFolderPath(
            Environment.SpecialFolder.LocalApplicationData);

        var appFolder = Path.Combine(folder, "AppointCare");
        Directory.CreateDirectory(appFolder);

        return Path.Combine(appFolder, "appointcare.db");
    }
}