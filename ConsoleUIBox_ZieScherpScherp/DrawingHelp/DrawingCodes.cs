using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUIBox_ZieScherpScherp.DrawingHelp
{
    internal static class DrawingCodes
    {
        //https://en.wikipedia.org/wiki/Box-drawing_characters  

        public static char UpperLeftCorner = '┌';
        public static char UpperRightCorner = '┐';
        public static char LowerRightCorner = '┘';
        public static char LowerLeftCorner = '└';
        public static char HorizontalLine = '─';
        public static char VerticalLine = '│';
        public static char CrossedLines = '┼';
    }
}
