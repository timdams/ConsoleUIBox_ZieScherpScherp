using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUIBox_ZieScherpScherp
{
    public enum ElementState { Inactive, Active, Selected }
    abstract public class  Control
    {
        public Action OnClick { get; set; }


        public Control(int w, int h)
        {
            Width = w;
            Height = h;
            ElementState = ElementState.Active;
        }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public virtual void Draw(int x, int y) //Todo kleuren uit theme halen
        {
            switch (ElementState)
            {
                case ElementState.Inactive:
                    ForegroundColor = ConsoleColor.Gray;
                    BackgroundColor= ConsoleColor.DarkGray;
                    break;
                case ElementState.Active:
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                    break;
                case ElementState.Selected:
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                default:
                    break;
            }
        }

        public virtual ElementState ElementState { get; set; } 

        public ConsoleColor ForegroundColor { get; set; }
        public ConsoleColor BackgroundColor { get; set; }

        public void Click()
        {
            if (OnClick != null)
                OnClick();
        }
    }
}
