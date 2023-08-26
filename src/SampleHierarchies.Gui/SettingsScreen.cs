using SampleHierarchies.Data;
using SampleHierarchies.Enums;
using SampleHierarchies.Interfaces.Data;
using SampleHierarchies.Interfaces.Services;
using SampleHierarchies.Services;

namespace SampleHierarchies.Gui;

/// <summary>
/// Application main screen.
/// </summary>
public sealed class SettingsScreen : Screen
{
    #region Properties And Ctor
    /// <summary>
    /// Animals screen.
    /// </summary>
    private MainScreenColor _mainScreenColor;

    /// <summary>
    /// Ctor.
    /// </summary>
    /// <param name="dataService">Data service reference</param>
    /// <param name="animalsScreen">Animals screen</param>
    public SettingsScreen(
        MainScreenColor mainScreenColor)
    {
        _mainScreenColor = mainScreenColor;
    }

    #endregion Properties And Ctor

    #region Public Methods

    /// <inheritdoc/>
    public override void Show()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Your available choices are:");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Change the color of the main screen");
            Console.WriteLine("2. Change the color of the animal screen");
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

                SettingsScreenChoices choice = (SettingsScreenChoices)Int32.Parse(choiceAsString);
                switch (choice)
                {
                    case SettingsScreenChoices.Main:
                        _mainScreenColor.Show();
                        break;
                    case SettingsScreenChoices.Animals:
                        _mainScreenColor.Show();
                        break;
                    case SettingsScreenChoices.Mammals:
                        _mainScreenColor.Show();
                        break;
                    case SettingsScreenChoices.Dogs:
                        _mainScreenColor.Show();
                        break;
                    case SettingsScreenChoices.Exit:
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
}
#endregion