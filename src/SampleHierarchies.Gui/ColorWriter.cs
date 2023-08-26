using SampleHierarchies.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Gui
{
    public class ColorWriter : TextWriter
    {
        // The color to use for the background
        public ConsoleColor Color { get; set; }

        public override Encoding Encoding => throw new NotImplementedException();

        // The original output stream
        private TextWriter originalOut;

        // The constructor that takes one argument of type ConsoleColor
        public ColorWriter(ConsoleColor color) : base((IFormatProvider?)Encoding.Default)
        {
            // Set the color property to the argument value
            Color = color;
            // Set the originalOut field to the current output stream
            originalOut = Console.Out;
        }
        // The rest of the class definition
    }

}
