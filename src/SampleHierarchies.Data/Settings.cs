using SampleHierarchies.Interfaces.Data;
using System.Runtime;
using System.Text.Json;
using SampleHierarchies.Interfaces.Data;
using System.Collections.Generic;

namespace SampleHierarchies.Data
{
    public class Settings : ISettings
    {
        public Dictionary<string, ConsoleColor> ScreenColors { get; set; }
    }
}