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

        public override void Draw(int x, int y)
        {
            base.Draw(x, y);


            DrawingLib.DrawRectangle(x, y, Width, Height, ForegroundColor, BackgroundColor);

            Content.Draw(x + 1, y + Height / 2);

        }

 

    }
}
