using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUIBox_ZieScherpScherp.DrawingHelp
{
    public class DrawingLib
    {
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
        public static void DrawAction(Action action)
        {
            SaveColor();
            action();
            RestoreColor();
        }

        public static void DrawRectangle(int x, int y, int width, int height, ConsoleColor lineColor = ConsoleColor.White, ConsoleColor fillColor = ConsoleColor.Black, bool noFill = false)
        {
            DrawAction(() =>
            {

                Console.ForegroundColor = lineColor;
                //Horizontale bovenkant
                Console.SetCursorPosition(x, y);
                Console.Write(DrawingCodes.UpperLeftCorner);
                for (int i = 0; i < width - 2; i++)
                {
                    Console.Write(DrawingCodes.HorizontalLine);
                }
                Console.Write(DrawingCodes.UpperRightCorner);

                //Horizontale onderkant
                Console.SetCursorPosition(x, y + height - 1);
                Console.Write(DrawingCodes.LowerLeftCorner);
                for (int i = 0; i < width - 2; i++)
                {
                    Console.Write(DrawingCodes.HorizontalLine);
                }
                Console.Write(DrawingCodes.LowerRightCorner);

                //Vertikaal

                for (int i = 0; i < height - 2; i++)
                {
                    Console.SetCursorPosition(x, y + 1 + i);
                    Console.Write(DrawingCodes.VerticalLine);
                    Console.SetCursorPosition(x + width - 1, y + 1 + i);
                    Console.Write(DrawingCodes.VerticalLine);
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
            });
            
        }

        public static void DrawTextLine(string tekst, int x, int y, int maxWidth = int.MaxValue, ConsoleColor textColor = ConsoleColor.White, ConsoleColor fillColor = ConsoleColor.Black)
        {

            DrawAction(() =>
            {

                Console.ForegroundColor = textColor;
                Console.BackgroundColor = fillColor;
                string toWrite = tekst;
                if (tekst.Length > maxWidth)
                    toWrite = tekst.Substring(0, maxWidth);
                Console.SetCursorPosition(x, y);
                Console.Write(toWrite);

            });
        }



    }
}
