using SampleHierarchies.Data;
using SampleHierarchies.Enums;
using SampleHierarchies.Interfaces.Data;
using SampleHierarchies.Interfaces.Services;
using SampleHierarchies.Services;
using System;

namespace SampleHierarchies.Gui;

/// <summary>
/// Application main screen.
/// </summary>
public sealed class MainScreenColor : Screen
{
    #region Properties And Ctor
    /// <summary>
    /// Data service.
    /// </summary>
    private IDataService _dataService;

    /// <summary>
    /// Animals screen.
    /// </summary>
    private AnimalsScreen _animalsScreen;
    private SettingsScreen _settingsScreen;
    private MainScreenColor _mainScreenColor;

    #endregion Properties And Ctor

    #region Public Methods

    /// <inheritdoc/>

    public override void Show()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Choose the color:");
            Console.WriteLine("0. Exit from this menu");
            Console.WriteLine("1. Blue");
            Console.WriteLine("2. Red");
            Console.WriteLine("3. Change the color of the mammals screen");
            Console.WriteLine("4. Change the color of the dogs screen");
            Console.Write("Please enter your choice: ");

            string? choiceAsString = Console.ReadLine();

            // Validate choice
            try
            {
                if (choiceAsString is null)
                {
                    throw new ArgumentNullException(nameof(choiceAsString));
                }
                MainScreenColorChoices choice = (MainScreenColorChoices)Int32.Parse(choiceAsString);
                switch (choice)
                {
                    case MainScreenColorChoices.Blue:
                        // Create a new block scope
                        {
                            // Create a new ColorWriter object with the blue background color
                            ColorWriter cw = new ColorWriter(ConsoleColor.Blue);
                            // Create a new MainScreen object with the ColorWriter
                            MainScreen ms = new MainScreen(
                                _dataService,
                                _animalsScreen,
                                _settingsScreen,
                                _mainScreenColor,
                                cw);
                            // Call its Show method
                            ms.Show();
                        }
                        // The cw variable is no longer accessible here
                        break;

                    case MainScreenColorChoices.Red:
                        // Create a new block scope
                        {
                            // Create a new ColorWriter object with the red background color
                            ColorWriter cw = new ColorWriter(ConsoleColor.Red);
                            // Create a new MainScreen object with the ColorWriter
                            MainScreen ms = new MainScreen(
                                _dataService,
                                _animalsScreen,
                                _settingsScreen,
                                _mainScreenColor,
                                cw);
                            // Call its Show method
                            ms.Show();
                        }
                        // The cw variable is no longer accessible here
                        break;


                    case MainScreenColorChoices.Exit:
                        Console.WriteLine("Goodbye.");
                        return;
                }
            }
            catch
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
        #endregion
    }
}
