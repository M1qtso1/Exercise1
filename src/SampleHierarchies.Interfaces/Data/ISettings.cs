using System;

namespace SampleHierarchies.Interfaces.Data
{
    public interface ISettings
    {
        string Version { get; set; }
        //ConsoleColor MainScreenColor { get; set; }
        //ConsoleColor AnimalScreenColor { get; set; }
        //ConsoleColor MammalScreenColor { get; set; }
        //ConsoleColor ScreenColor { get; set; }
        //ConsoleColor DogScreenColor { get; set; }
        Dictionary<string, ConsoleColor> ScreenColors { get; set; }

        //string JsonPath { get; set; }
    }

}
