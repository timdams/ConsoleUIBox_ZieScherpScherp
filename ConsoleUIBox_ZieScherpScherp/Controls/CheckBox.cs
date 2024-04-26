using ConsoleUIBox_ZieScherpScherp.DrawingHelp;

namespace ConsoleUIBox_ZieScherpScherp.Controls
{
    public class CheckBox : Button
    {
        public bool IsChecked { get; private set; }

        public CheckBox(string text, bool startStateChecked) : base(text, null, text.Length + 4, 1)
        {

            OnClick = this.ChangeChecked;
            IsChecked = startStateChecked;

        }

        public override void Draw(int x, int y)
        {

            ;
            switch (ElementState)
            {
                case ElementState.Inactive:
                    DrawingLib.DrawTextLine($"[{(IsChecked ? 'x' : ' ')}] {Text}", x, y, int.MaxValue, ConsoleColor.Gray, ConsoleColor.DarkGray);
                    break;
                case ElementState.Active:
                    DrawingLib.DrawTextLine($"[{(IsChecked ? 'x' : ' ')}] {Text}", x, y, int.MaxValue);
                    break;
                case ElementState.Selected:
                    DrawingLib.DrawTextLine($"[{(IsChecked ? 'x' : ' ')}] {Text}", x, y, int.MaxValue, ConsoleColor.Yellow, ConsoleColor.DarkYellow);
                    break;
                default:
                    break;
            }

        }

        public void ChangeChecked()
        {
            IsChecked = !IsChecked;
        }
    }
}
