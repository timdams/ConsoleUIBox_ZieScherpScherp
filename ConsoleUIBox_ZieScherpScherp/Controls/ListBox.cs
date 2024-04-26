using ConsoleUIBox_ZieScherpScherp.DrawingHelp;

namespace ConsoleUIBox_ZieScherpScherp.Controls
{
    public class ListBox : UIElement
    {

        public ListBox() : base(1, 1)
        {

        }

        public List<UIElement> Items { get; set; } = new List<UIElement>();

        public override void Draw(int x, int y)
        {
            int currHeight = 1;
            int maxW = 0;
            foreach (var item in Items)
            {
                item.Draw(x + 1, y + currHeight);
                if (item.Width > maxW)
                    maxW = item.Width;

                currHeight += item.Height + 1;
            }

            //Border
            DrawingLib.DrawRectangle(x, y, maxW + 2, currHeight, noFill: true);

            //Todo moet herberekent on the fly?
            Width = maxW + 2;
            Height = currHeight;

        }
    }
}
