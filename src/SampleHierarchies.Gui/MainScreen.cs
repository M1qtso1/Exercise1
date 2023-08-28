using SampleHierarchies.Enums;
using SampleHierarchies.Interfaces.Services;
using SampleHierarchies.Services;
using SampleHierarchies.Data;
using SampleHierarchies.Interfaces.Data;

namespace SampleHierarchies.Gui;

/// <summary>
/// Application main screen.
/// </summary>
public sealed class MainScreen : Screen
{
    private void ResetConsoleColor()
    {
        Console.ResetColor();
    }
    #region Properties And Ctor

    /// <summary>
    /// Data service.
    /// </summary>
    private IDataService _dataService;
    private AnimalsScreen _animalsScreen;
    private ISettingsService _settingsService;
    private ISettings _settings;
    //private SettingsScreen _settingsScreen;

    /// <summary>
    /// Ctor.
    /// </summary>
    /// <param name="dataService">Data service reference</param>
    /// <param name="animalsScreen">Animals screen</param>
    public MainScreen(IDataService dataService, AnimalsScreen animalsScreen, SettingsService settingsService /*SettingsScreen settingsScreen*/)
    {
        _dataService = dataService;
        _animalsScreen = animalsScreen;
        _settingsService = settingsService;
        _settings = settingsService.GetSettings();
        //_settingsScreen = settingsScreen;

        //_settings = _settingsService.Read("Settings.json") ?? new Settings
        //{
        //    Version = "1.0",
        //    ScreenColors = new Dictionary<string, ConsoleColor>
        //    {
        //        { "MainScreen", ConsoleColor.Magenta },
        //        { "AnimalScreen", ConsoleColor.DarkCyan },
        //        { "MammalsScreen", ConsoleColor.DarkBlue },
        //        { "DogsScreen", ConsoleColor.Yellow }
        //    }
        //};

        // Load settings
        //*settings = _settingsService.Read("settings.json") ?? new Settings();*/
    }


    #endregion Properties And Ctor

    #region Public Methods

    /// <inheritdoc/>
    public override void Show()
    {
        
        //Console.ForegroundColor = _settings.MainScreenColor;
        while (true)
        {
            Console.ForegroundColor = _settings.ScreenColors["MainScreen"];
            Console.WriteLine();
            Console.WriteLine("Your available choices are:");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Animals");
            Console.WriteLine("2. Create a new settings");
            Console.Write("Please enter your choice: ");

            string? choiceAsString = Console.ReadLine();

            // Validate choice
            try
            {
                if (choiceAsString is null)
                {
                    throw new ArgumentNullException(nameof(choiceAsString));
                }

                MainScreenChoices choice = (MainScreenChoices)Int32.Parse(choiceAsString);
                switch (choice)
                {
                    case MainScreenChoices.Animals:
                        _animalsScreen.Show();
                        break;

                    case MainScreenChoices.Settings:
                        //ModifySettings();
                        //_settingsScreen.Show();
                        ShowSettingsMenu();
                        //_settingsService.Write(_settings, "settings.json");
                        break;

                    case MainScreenChoices.Exit:
                        Console.WriteLine("Goodbye.");
                        return;
                }
            }
            catch
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
            
        }
    }
    private void ShowSettingsMenu()
    {
        while (true)
        {
            Console.ForegroundColor = _settings.ScreenColors["MainScreen"];
            Console.WriteLine();
            Console.WriteLine("Settings Menu:");
            Console.WriteLine("1. Change Colors");
            Console.WriteLine("2. Write Settings to JSON");
            Console.WriteLine("3. Read Settings from JSON");
            Console.WriteLine("0. Back to Main Menu");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ChangeColors();
                    break;
                case "2":
                    WriteSettingsToJson();
                    break;
                case "3":
                    ReadSettingsFromJson();
                    break;
                case "0":
                    return; // Go back to the Main Menu
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    private void ChangeColors()
    {
        while (true)
        {
            Console.ForegroundColor = _settings.ScreenColors["MainScreen"];
            Console.WriteLine();
            Console.WriteLine("Select a screen to change its color:");
            Console.WriteLine("1. MainScreen");
            Console.WriteLine("2. AnimalScreen");
            Console.WriteLine("3. MammalsScreen");
            Console.WriteLine("4. DogsScreen");
            Console.WriteLine("0. Back to Settings Menu");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "0")
            {
                return;
            }

            if (int.TryParse(choice, out int screenChoice) && screenChoice >= 1 && screenChoice <= 4)
            {
                Console.Write("Enter a new color (e.g., Red, Green, Yellow): ");
                string newColor = Console.ReadLine();

                if (Enum.TryParse(newColor, out ConsoleColor color))
                {
                    string[] screenNames = { "MainScreen", "AnimalScreen", "MammalsScreen", "DogsScreen" };
                    string selectedScreen = screenNames[screenChoice - 1];

                    // Update the color in _settings.ScreenColors
                    _settings.ScreenColors[selectedScreen] = color;
                    Console.WriteLine($"{selectedScreen} color has been updated to {color}.");
                }
                else
                {
                    Console.WriteLine("Invalid color. Please enter a valid ConsoleColor.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }

    private void WriteSettingsToJson()
    {
        _settingsService.Write(_settings, "Settings.json");
        Console.WriteLine("Settings have been written to Settings.json.");
    }

    private void ReadSettingsFromJson()
    {
        _settings = _settingsService.Read("Settings.json") ?? _settings;
        Console.WriteLine("Settings have been read from Settings.json.");
    }


    //private void ModifySettings()
    //{
    //    Console.WriteLine("Modify Settings:");
    //    Console.Write("Enter Main Screen Color: ");
    //    _settings.MainScreenColor = (ConsoleColor)Convert.ToInt32(Console.ReadLine()); 

    //    Console.Write("Enter Animal Screen Color: ");
    //    _settings.AnimalScreenColor = (ConsoleColor)Convert.ToInt32(Console.ReadLine());

    //    Console.Write("Enter Mammal Screen Color: ");
    //    _settings.MammalScreenColor = (ConsoleColor)Convert.ToInt32(Console.ReadLine());

    //    Console.Write("Enter Dog Screen Color: ");
    //    _settings.DogScreenColor = (ConsoleColor)Convert.ToInt32(Console.ReadLine());
    //}
    #endregion // Public Methods
}