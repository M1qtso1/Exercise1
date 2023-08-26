using SampleHierarchies.Interfaces.Data;
using SampleHierarchies.Interfaces.Services;
using System.IO;
using System.Text.Json;

namespace SampleHierarchies.Services;
/// <summary>
/// Settings service.
/// </summary>
public class SettingsService : ISettingsService
{
    #region ISettings Implementation 
    /// <inheritdoc/>
    public ISettings? Read(string jsonPath)
    {
        ISettings? result = null;
        try
        {
            // Read the JSON file as a string
            string jsonString = File.ReadAllText(jsonPath);
            // Deserialize the JSON string to an ISettings object
            result = JsonSerializer.Deserialize<ISettings>(jsonString);
        }
        catch (Exception ex)
        {
            // Handle any exceptions that may occur
            Console.WriteLine(ex.Message);
        }
        return result;
    }

    /// <inheritdoc/>
    public void Write(ISettings settings, string jsonPath)
    {
        try
        {
            // Serialize the ISettings object to a JSON string
            string jsonString = JsonSerializer.Serialize(settings);
            // Write the JSON string to a file
            File.WriteAllText(jsonPath, jsonString);
        }
        catch (Exception ex)
        {
            // Handle any exceptions that may occur
            Console.WriteLine(ex.Message);
        }

    }

    #endregion // ISettings Implementation 
}
