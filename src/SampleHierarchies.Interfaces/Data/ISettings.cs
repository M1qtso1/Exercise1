namespace SampleHierarchies.Interfaces.Data;
/// <summary>
/// Settings interface.
/// </summary>
public interface ISettings
{
    #region Interface Members
    /// <summary>
    /// Version of settings.
    /// </summary>
    string Version { get; set; }

    /// <summary>
    /// Colour of main screen.
    /// </summary>
    string MainScreenColor { get; set; }

    /// <summary>
    /// Colour of animal screen.
    /// </summary>
    string AnimalScreenColor { get; set; }

    /// <summary>
    /// Colour of mammal screen.
    /// </summary>
    string MammalScreenColor { get; set; }

    /// <summary>
    /// Colour of dog screen.
    /// </summary>
    string DogScreenColor { get; set; }

    #endregion // Interface Members
}
