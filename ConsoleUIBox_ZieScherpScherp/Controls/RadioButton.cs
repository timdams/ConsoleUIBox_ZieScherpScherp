using ConsoleUIBox_ZieScherpScherp.BaseAbstractControls;
using ConsoleUIBox_ZieScherpScherp.DrawingHelp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUIBox_ZieScherpScherp.Controls
{
    public class RadioButton : ToggleControl
    {
        public RadioButton(ContentControl text, bool startStateChecked) : base(text, startStateChecked)
        {
        }
        public override void DrawAction(int x, int y)
        {

            //TODO hier ben ik
            DrawingLib.DrawTextLine($"({(IsChecked ? '•' : ' ')})", x, y, int.MaxValue, ForegroundColor, BackgroundColor);

            Content.DrawAction(x + 4, y);

        }
    }
}
