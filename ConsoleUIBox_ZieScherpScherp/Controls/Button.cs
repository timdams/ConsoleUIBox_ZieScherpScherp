using ConsoleUIBox_ZieScherpScherp.DrawingHelp;


namespace ConsoleUIBox_ZieScherpScherp.Controls
{
    public class Button : UIElement
    {
        public Action OnClick { get; set; }
        public string Text { get; set; }

        public Button(string tekst, Action action, int width, int height) : base(width, height)
        {
            Text = tekst;
            OnClick = action;
        }

        public override void Draw(int x, int y)
        {
            switch (ElementState)
            {
                case ElementState.Inactive:
                    DrawingLib.DrawRectangle(x, y, Width, Height, ConsoleColor.Gray, ConsoleColor.DarkGray);
                    DrawingLib.DrawTextLine(Text, x + 1, y + Height / 2, Width - 2, ConsoleColor.Gray, ConsoleColor.DarkGray);
                    break;
                case ElementState.Active:
                    DrawingLib.DrawRectangle(x, y, Width, Height);
                    DrawingLib.DrawTextLine(Text, x + 1, y + Height / 2, Width - 2);
                    break;
                case ElementState.Selected:
                    DrawingLib.DrawRectangle(x, y, Width, Height, ConsoleColor.Yellow, ConsoleColor.DarkYellow);
                    DrawingLib.DrawTextLine(Text, x + 1, y + Height / 2, Width - 2, ConsoleColor.Yellow, ConsoleColor.DarkYellow);
                    break;
                default:
                    break;
            }

        }

        public void Click()
        {
            if (OnClick != null)
                OnClick();
        }

    }
}
