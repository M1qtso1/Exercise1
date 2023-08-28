using SampleHierarchies.Interfaces.Data;
using System.Runtime;
using System.Text.Json;
using SampleHierarchies.Interfaces.Data;
using System.Collections.Generic;

namespace SampleHierarchies.Data
{
    public class Settings : ISettings
    {
        public string Version { get; set; }
        public Dictionary<string, ConsoleColor> ScreenColors { get; set; }
        public Settings()
        {
            ScreenColors = new Dictionary<string, ConsoleColor>
            {
                { "MainScreen", ConsoleColor.Magenta },
                { "AnimalScreen", ConsoleColor.Red },
                { "MammalsScreen", ConsoleColor.DarkBlue },
                { "DogsScreen", ConsoleColor.Yellow }
            };
        }

        //public ConsoleColor MainScreenColor { get; set; }
        //public ConsoleColor AnimalScreenColor { get; set; }
        //public ConsoleColor MammalScreenColor { get; set; }
        //public ConsoleColor DogScreenColor { get; set; }
        // Method to read settings from a JSON file
        //public static Settings LoadFromJson(string jsonPath)
        //{
        //    try
        //    {
        //        if (File.Exists(jsonPath))
        //        {
        //            // Read the JSON content from the file
        //            string json = File.ReadAllText(jsonPath);

        //            // Deserialize the JSON into a Settings object
        //            return JsonSerializer.Deserialize<Settings>(json);
        //        }
        //        else
        //        {
        //            // If the file doesn't exist, return a new Settings object
        //            return new Settings();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle any exceptions that might occur during reading
        //        // You might want to log the exception or take appropriate action
        //        return new Settings();
        //    }
        //}

        //// Method to write settings to a JSON file
        //public void SaveToJson(string jsonPath)
        //{
        //    try
        //    {
        //        // Serialize the Settings object to JSON
        //        string json = JsonSerializer.Serialize(this);

        //        // Write the JSON to the specified file
        //        File.WriteAllText(jsonPath, json);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle any exceptions that might occur during writing
        //        // You might want to log the exception or take appropriate action
        //    }
        //}
    }
}