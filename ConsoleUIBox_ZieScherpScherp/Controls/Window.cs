using ConsoleUIBox_ZieScherpScherp.DrawingHelp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUIBox_ZieScherpScherp.Controls
{
    public class Window : ContentControl
    {
        public string Title { get; set; }
        public Window(int w, int h, string title="WindowTitle") : base(w, h)
        {
            Title = title;
        }

        public override void DrawAction(int x, int y)
        {
            
            DrawingLib.DrawRectangle(x, y, Width, Height, ForegroundColor, BackgroundColor);
                       
            string tit = Title;

            DrawingLib.DrawTextLine(tit, x + 1, y, Width - 2, ForegroundColor, BackgroundColor);
            base.DrawAction(x+1, y+1);
        }
    }
}
