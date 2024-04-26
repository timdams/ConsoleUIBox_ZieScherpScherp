using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUIBox_ZieScherpScherp
{
    public enum ElementState { Inactive, Active, Selected }
    abstract public class  Control
    {
        private ElementState elementState;

        public Action OnClick { get; set; }


        public Control(int w, int h)
        {
            Width = w;
            Height = h;
            ElementState = ElementState.Active;
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
        }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        protected virtual void PreDraw()
        {
            //Todo kleuren uit theme halen

        }

        public void Draw(int x, int y)
        {
            PreDraw();
            DrawAction(x, y);
        }

        public abstract void DrawAction(int x, int y);

        public virtual ElementState ElementState
        {
            get => elementState;
            set 
            { 
                elementState = value;
                switch (value)
                {
                    case ElementState.Inactive:
                        ForegroundColor = ConsoleColor.Gray;
                        BackgroundColor = ConsoleColor.DarkGray;
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
        }

        public ConsoleColor ForegroundColor { get; set; }
        public ConsoleColor BackgroundColor { get; set; }

        public void Click()
        {
            if (OnClick != null)
                OnClick();
        }
    }
}
