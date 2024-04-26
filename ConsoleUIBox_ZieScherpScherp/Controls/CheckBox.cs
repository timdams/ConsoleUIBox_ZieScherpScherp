using ConsoleUIBox_ZieScherpScherp.BaseAbstractControls;
using ConsoleUIBox_ZieScherpScherp.DrawingHelp;

namespace ConsoleUIBox_ZieScherpScherp.Controls
{
    public class CheckBox : ToggleControl //beter toggle button zoals radiobutton?
    {
       

        public CheckBox(ContentControl text, bool startStateChecked) : base( text, startStateChecked)
        {
            

        }

        public override void DrawAction(int x, int y)
        {

       
            DrawingLib.DrawTextLine($"[{(IsChecked ? 'x' : ' ')}]", x, y, int.MaxValue,ForegroundColor,BackgroundColor);

            Content.DrawAction(x + 4, y);

        }


    }
}
