using ConsoleUIBox_ZieScherpScherp.DrawingHelp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUIBox_ZieScherpScherp.Controls
{
    public class TextBlock : ContentControl
    {
        public TextBlock( string text) : base(text.Length, 1)
        {
            Text = text;
        }

        public string Text { get; set; }
        public override void Draw(int x, int y)
        {
            base.Draw(x, y);
            DrawingLib.DrawTextLine(Text,x,y, Width, ForegroundColor,BackgroundColor);
        }
    }
}
