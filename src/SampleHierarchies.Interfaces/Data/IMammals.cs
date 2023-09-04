using SampleHierarchies.Interfaces.Data.Mammals;

namespace SampleHierarchies.Interfaces.Data;

/// <summary>
/// Mammals collection.
/// </summary>
public interface IMammals
{
    #region Interface Members

    /// <summary>
    /// Animals collections.
    /// </summary>
    List<IDog> Dogs { get; set; }
    List<IOrangutan> Orangutans { get; set; }
    List<IChimpanzee> Chimpanzees { get; set; }
    List<IWhale> Whales { get; set; }

    #endregion // Interface Members
}
