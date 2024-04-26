using ConsoleUIBox_ZieScherpScherp.DrawingHelp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUIBox_ZieScherpScherp
{
    public class ItemsControl : Control
    {
        public ItemsControl(int w, int h) : base(w, h)
        {
        }
        public List<ContentControl> Items { get; set; } = new List<ContentControl>();

        public override void Draw(int x, int y)
        {
            base.Draw(x, y);
            int currHeight = 1;

            foreach (var item in Items)
            {
                item.Draw(x + 1, y + currHeight);

                currHeight += item.Height + 1;
            }

            //Border
            DrawingLib.DrawRectangle(x, y, Width, currHeight, noFill: true);


        }
    }
}
