using SampleHierarchies.Interfaces.Data;
using SampleHierarchies.Interfaces.Services;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using SampleHierarchies.Data;

namespace SampleHierarchies.Services
{
    public class SettingsService : ISettingsService
    {

        private ISettings _settings;

        public SettingsService()
        {
            // Initialize settings (load from file or create defaults)
            _settings = Read("Settings.json") ?? new Settings
            {
                Version = "1.0"
            };
        }

        public ISettings GetSettings()
        {
            return _settings;
        }

        public ISettings? Read(string jsonPath)
        {
            if (!File.Exists(jsonPath))
            {
                return null;
            }

            string json = File.ReadAllText(jsonPath);
            return JsonConvert.DeserializeObject<Settings>(json);
        }

        public void Write(ISettings settings, string jsonPath)
        {
            string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(jsonPath, json);
        }
        //private ISettings _settings;

        //public SettingsService()
        //{
        //    // Initialize settings (load from file or create defaults)
        //    _settings = Read("Settings.json") ?? new Settings
        //    {
        //        Version = "1.0",
        //        ScreenColors = new Dictionary<string, ConsoleColor>
        //        {
        //            { "MainScreen", ConsoleColor.Magenta },
        //            { "AnimalScreen", ConsoleColor.DarkCyan },
        //            { "MammalsScreen", ConsoleColor.DarkBlue },
        //            { "DogsScreen", ConsoleColor.Yellow }
        //        }
        //    };
        //}

        //public ISettings GetSettings()
        //{
        //    return _settings;
        //}

        //public ISettings? Read(string jsonPath)
        //{
        //    if (!File.Exists(jsonPath))
        //    {
        //        return null;
        //    }

        //    string json = File.ReadAllText(jsonPath);
        //    return JsonConvert.DeserializeObject<Settings>(json);
        //}

        //public void Write(ISettings settings, string jsonPath)
        //{
        //    string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
        //    File.WriteAllText(jsonPath, json);
        //}
    }
}




//{
//#region ISettings Implementation
//public Dictionary<string, ConsoleColor> ScreenColors { get; set; }
//public Dictionary<string, ConsoleColor> DeserializeSettingsFile()
//{
//    try
//    {
//        string json = File.ReadAllText(JsonPath);
//        var deserializedMenuColors.ToDictionary(keyValue => keyValue.Key, keyValue => (ConsoleColor)Enum.Parse(typeof(ConsoleColor), keyValue.Value));
//        return menuColors;
//    }
//    catch(FileNotFoundException)
//    {
//        Console.WriteLine($"File {JsonPath} does not exist.");
//        return null;
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Error during deserialization: {ex.Message}");
//    }
//}
///// <inheritdoc/>
//public ISettings? Read(string jsonPath)
//{
//    ISettings? result = null;

//    return result;
//}

///// <inheritdoc/>
//public void Write(ISettings settings, string jsonPath)
//{

//}
//public ConsoleColor ScreenColor { get; set; }

//public string JsonPath { get; set; }
//public string Version { get; set; }
//public ConsoleColor SetColor (string jsonPath, string ScreenName)
//{
//    return ConsoleColor.Green;
//}
//public SettingsService()
//{
//    JsonPath = "ScreenColors.json";
//}
//public SettingsService(ConsoleColor screenColor, string jsonPath, string version)
//{
//    ScreenColor = screenColor;
//    this.JsonPath = jsonPath;
//    Version = version;
//}
//public void SerializeSettingsFile()
//{
//    ScreenColors = new Dictionary<string, ConsoleColor>
//    {
//        { "MainScreen", ConsoleColor.Magenta },
//        { "AnimalScreen", ConsoleColor.DarkCyan },
//        { "MammalsScreen", ConsoleColor.DarkBlue },
//        { "DogsScreen", ConsoleColor.Yellow },
//    };

//    var serializedScreenColors = ScreenColors.ToDictionary(sc => sc.Key, sc => sc.Value.ToString());
//    string menuColorsAsString = JsonConvert.SerializeObject(serializedScreenColors);
//    File.WriteAllText("ScreenColors.json", menuColorsAsString);
//}

//void ISettingsService.SetColor(string filePath, string screenName)
//{
//    throw new NotImplementedException();
//}

//public void SetScreenColor(string screenName)
//{
//    Dictionary<string, ConsoleColor> colorsOfMenu = DeserializeSettingsFile();
//    if (colorsOfMenu.ContainsKey(screenName))
//    {
//        ConsoleColor color = colorsOfMenu[screenName];
//        Console.ForegroundColor = color;
//    }
//    else
//    {
//        Console.WriteLine($"Color for '{screenName}' menu wasn't found");
//    }
//}
//#endregion // ISettings Implementation
//}