using ConsoleUIBox_ZieScherpScherp.DrawingHelp;

namespace ConsoleUIBox_ZieScherpScherp.Controls
{
    public class CheckBox : ContentControl //beter toggle button zoals radiobutton?
    {
        public bool IsChecked { get; private set; }

        public CheckBox(ContentControl text, bool startStateChecked) : base( text.Width + 4, 1)
        {
            Content = text;
            OnClick = ChangeChecked;
            IsChecked = startStateChecked;

        }

        public override void Draw(int x, int y)
        {

            base.Draw(x, y);

            DrawingLib.DrawTextLine($"[{(IsChecked ? 'x' : ' ')}]", x, y, int.MaxValue,ForegroundColor,BackgroundColor);

            Content.Draw(x + 4, y);

        }

        public void ChangeChecked()
        {
            IsChecked = !IsChecked;
        }
    }
}
