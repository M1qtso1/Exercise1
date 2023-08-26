using SampleHierarchies.Enums;
using System.Drawing;

namespace SampleHierarchies.Gui;

/// <summary>
/// Mammals main screen.
/// </summary>
public sealed class MammalsScreen : Screen
{
    #region Properties And Ctor

    /// <summary>
    /// Animals screen.
    /// </summary>
    private DogsScreen _dogsScreen; 
    private OrangutanScreen _orangutanScreen;
    private ChimpanzeeScreen _chimpanzeeScreen;
    private WhaleScreen _whaleScreen;

    /// <summary>
    /// Ctor.
    /// </summary>
    /// <param name="dataService">Data service reference</param>
    /// <param name="orangutanScreen">Orangutans screen</param>
    /// <param name="chimpanzeeScreen">Chimpanzees screen</param>
    /// <param name="whaleScreen">Whales screen</param>
    /// Override the Display method to use the mammal screen color from the settings
    public MammalsScreen(DogsScreen dogsScreen, OrangutanScreen orangutanScreen, ChimpanzeeScreen chimpanzeeScreen, WhaleScreen whaleScreen)
    {
        _dogsScreen = dogsScreen;
        _orangutanScreen = orangutanScreen;
        _chimpanzeeScreen = chimpanzeeScreen;
        _whaleScreen = whaleScreen;
    }

    public Color BackColor { get; internal set; }

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
            Console.WriteLine("1. Dogs");
            Console.WriteLine("2. Orangutans");
            Console.WriteLine("3. Chimpanzee");
            Console.WriteLine("4. Whale");
            Console.Write("Please enter your choice: ");

            string? choiceAsString = Console.ReadLine();

            // Validate choice
            try
            {
                if (choiceAsString is null)
                {
                    throw new ArgumentNullException(nameof(choiceAsString));
                }

                MammalsScreenChoices choice = (MammalsScreenChoices)Int32.Parse(choiceAsString);
                switch (choice)
                {
                    case MammalsScreenChoices.Dogs:
                        _dogsScreen.Show();
                        break;

                    case MammalsScreenChoices.Orangutan:
                        _orangutanScreen.Show();
                        break;

                    case MammalsScreenChoices.Chimpanzee:
                        _chimpanzeeScreen.Show();
                        break;

                    case MammalsScreenChoices.Whale:
                        _whaleScreen.Show();
                        break;

                    case MammalsScreenChoices.Exit:
                        Console.WriteLine("Going back to parent menu.");
                        return;
                }
            }
            catch
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }

    #endregion // Public Methods
}
