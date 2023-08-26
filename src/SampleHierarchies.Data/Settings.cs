using SampleHierarchies.Interfaces.Data;

namespace SampleHierarchies.Data;
/// <summary>
/// Settings class.
/// </summary>
public class Settings : ISettings
{
    #region ISettings Implementation 
    /// <inheritdoc/>
    public string Version { get; set; }

    /// <inheritdoc/>
    public string MainScreenColor { get; set; }

    /// <inheritdoc/>
    public string AnimalScreenColor { get; set; }

    /// <inheritdoc/>
    public string MammalScreenColor { get; set; }

    /// <inheritdoc/>
    public string DogScreenColor { get; set; }

    #endregion // ISettings Implementation 
}
