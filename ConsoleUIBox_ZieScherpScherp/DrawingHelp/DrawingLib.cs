using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUIBox_ZieScherpScherp.DrawingHelp
{
    public class DrawingLib
    {
        //https://en.wikipedia.org/wiki/Box-drawing_characters 

        static char upperLeftCorner = '┌';
        static char upperRightCorner = '┐';
        static char lowerRightCorner = '┘';
        static char lowerLeftCorner = '└';
        static char horizontalLine = '─';
        static char verticalLine = '│';


        public static void DrawRectangle(int x, int y, int width, int height, ConsoleColor lineColor = ConsoleColor.White, ConsoleColor fillColor = ConsoleColor.Black, bool noFill = false)
        {
            SaveColor();

            Console.ForegroundColor = lineColor;
            //Horizontale bovenkant
            Console.SetCursorPosition(x, y);
            Console.Write(upperLeftCorner);
            for (int i = 0; i < width - 2; i++)
            {
                Console.Write(horizontalLine);
            }
            Console.Write(upperRightCorner);

            //Horizontale onderkant
            Console.SetCursorPosition(x, y + height - 1);
            Console.Write(lowerLeftCorner);
            for (int i = 0; i < width - 2; i++)
            {
                Console.Write(horizontalLine);
            }
            Console.Write(lowerRightCorner);

            //Vertikaal

            for (int i = 0; i < height - 2; i++)
            {
                Console.SetCursorPosition(x, y + 1 + i);
                Console.Write(verticalLine);
                Console.SetCursorPosition(x + width - 1, y + 1 + i);
                Console.Write(verticalLine);
            }

            //Vullen
            if (!noFill)
            {
                Console.BackgroundColor = fillColor;
                for (int i = 1; i < width - 1; i++)
                {
                    for (int j = 1; j < height - 1; j++)
                    {
                        Console.SetCursorPosition(i + x, j + y);
                        Console.Write(" ");
                    }
                }
            }
            RestoreColor();
        }

        public static void DrawTextLine(string tekst, int x, int y, int maxWidth = int.MaxValue, ConsoleColor textColor = ConsoleColor.White, ConsoleColor fillColor = ConsoleColor.Black)
        {

            SaveColor();
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = fillColor;
            string toWrite = tekst;
            if (tekst.Length > maxWidth)
                toWrite = tekst.Substring(0, maxWidth);
            Console.SetCursorPosition(x, y);
            Console.Write(toWrite);

            RestoreColor();
        }


        static ConsoleColor foreGroundColor = Console.ForegroundColor;
        static ConsoleColor backGroundColor = Console.BackgroundColor;

        public static void SaveColor()
        {
            foreGroundColor = Console.ForegroundColor;
            backGroundColor = Console.BackgroundColor;
        }
        public static void RestoreColor()
        {
            Console.ForegroundColor = foreGroundColor;
            Console.BackgroundColor = backGroundColor;
        }
    }
}
