using ConsoleUIBox_ZieScherpScherp.BaseAbstractControls;
using ConsoleUIBox_ZieScherpScherp.DrawingHelp;


namespace ConsoleUIBox_ZieScherpScherp.Controls
{
    public class Button : ContentControl
    {
       
        public Button(ContentControl content, Action action, int width, int height) : base(width, height)
        {
            Content = content;
            OnClick = action;
        }

        public override void DrawAction(int x, int y)
        {
           base.DrawAction(x, y);


            DrawingLib.DrawRectangle(x, y, Width, Height, ForegroundColor, BackgroundColor);

            Content.DrawAction(x + 1, y + Height / 2);
            
        }

 

    }
}
