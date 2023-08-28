//using SampleHierarchies.Interfaces.Data;
//using SampleHierarchies.Interfaces.Services;
//using SampleHierarchies.Services; // Assuming your SettingsService is in this namespace

//namespace SampleHierarchies.Gui
//{
//    public class SettingsScreen : Screen
//    {
//        private ISettings _settings;
//        private ISettingsService _settingsService;

//        public SettingsScreen(ISettings settings, ISettingsService settingsService)
//        {
//            _settings = settings;
//            _settingsService = settingsService;
//        }

//        public override void Show()
//        {
//            while (true)
//            {
//                Console.WriteLine("Settings Menu:");
//                Console.WriteLine("1. Change Colors");
//                Console.WriteLine("2. Write Settings to JSON");
//                Console.WriteLine("3. Read Settings from JSON");
//                Console.WriteLine("4. Back to Main Menu");

//                Console.Write("Enter your choice: ");
//                string choice = Console.ReadLine();

//                switch (choice)
//                {
//                    case "1":
//                        ChangeColors();
//                        break;
//                    case "2":
//                        WriteSettingsToJson();
//                        break;
//                    case "3":
//                        ReadSettingsFromJson();
//                        break;
//                    case "4":
//                        return; // Go back to the main menu
//                    default:
//                        Console.WriteLine("Invalid choice. Try again.");
//                        break;
//                }
//            }
//        }

//        private void ChangeColors()
//        {
//            while (true)
//            {
//                Console.WriteLine("Select a screen to change its color:");
//                Console.WriteLine("1. MainScreen");
//                Console.WriteLine("2. AnimalScreen");
//                Console.WriteLine("3. MammalsScreen");
//                Console.WriteLine("4. DogsScreen");
//                Console.WriteLine("5. Back to Settings Menu");

//                Console.Write("Enter your choice: ");
//                string choice = Console.ReadLine();

//                if (choice == "5")
//                {
//                    return; // Go back to the Settings Menu
//                }

//                if (int.TryParse(choice, out int screenChoice) && screenChoice >= 1 && screenChoice <= 4)
//                {
//                    Console.Write("Enter a new color (e.g., Red, Green, Yellow): ");
//                    string newColor = Console.ReadLine();

//                    if (Enum.TryParse(newColor, out ConsoleColor color))
//                    {
//                        string[] screenNames = { "MainScreen", "AnimalScreen", "MammalsScreen", "DogsScreen" };
//                        string selectedScreen = screenNames[screenChoice - 1];

//                        // Update the color in _settings.ScreenColors
//                        _settings.ScreenColors[selectedScreen] = color;
//                        Console.WriteLine($"{selectedScreen} color has been updated to {color}.");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Invalid color. Please enter a valid ConsoleColor.");
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Invalid choice. Try again.");
//                }
//            }
//        }

//        private void WriteSettingsToJson()
//        {
//            _settingsService.Write(_settings, "Settings.json");
//            Console.WriteLine("Settings have been written to Settings.json.");
//        }

//        private void ReadSettingsFromJson()
//        {
//            _settings = _settingsService.Read("Settings.json") ?? _settings;
//            Console.WriteLine("Settings have been read from Settings.json.");
//        }
//    }
//}

////using Newtonsoft.Json;
////using SampleHierarchies.Data;
////using SampleHierarchies.Interfaces.Data;
////using SampleHierarchies.Interfaces.Services;
////using System.IO;

////namespace SampleHierarchies.Services
////{
////    public class SettingsService : ISettingsService
////    {
////        public ISettings? Read(string jsonPath)
////        {
////            if (File.Exists(jsonPath))
////            {
////                string json = File.ReadAllText(jsonPath);
////                return JsonConvert.DeserializeObject<Settings>(json);
////            }
////            return null;
////        }

////        public void Write(ISettings settings, string jsonPath)
////        {
////            string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
////            File.WriteAllText(jsonPath, json);
////        }
////    }
////}
