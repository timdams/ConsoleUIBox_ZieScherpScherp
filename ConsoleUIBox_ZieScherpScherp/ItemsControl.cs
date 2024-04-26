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
        private const int itemspacing= 1; //TODO vertikaleruimte tussen ieder element. Mag niet nul zijn..snap niet waarom
        public ItemsControl(int w, int h) : base(w, h)
        {
        }
        public List<Control> Items { get; set; } = new List<Control>();
        public override int Height
        {
            get
            {
                int height = 1;

                foreach (var item in Items)
                {
                    height += item.Height + itemspacing;
                }
                return height;
            }

        }
        public override int Width
        {
            get
            {
                int maxW = 0;

                foreach (var item in Items)
                {
                    if (item.Width > maxW)
                        maxW = item.Width;
                }
                return maxW + 2;
            }

        }

        public override void DrawAction(int x, int y)
        {
            
            int currHeight = 1;

            foreach (var item in Items)
            {
                item.Draw(x + 1, y + currHeight);

                currHeight += item.Height + itemspacing;
            }

            //Border
            DrawingLib.DrawRectangle(x, y, Width, currHeight, noFill: true);


        }
    }
}
