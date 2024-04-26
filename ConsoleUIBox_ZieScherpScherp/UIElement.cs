
namespace ConsoleUIBox_ZieScherpScherp
{
    public enum ElementState { Inactive, Active, Selected }
    public abstract class UIElement
    {
        public UIElement(int w, int h)
        {
            Width = w;
            Height = h;
        }
        public int Width { get; set; }
        public int Height { get; set; }

        abstract public void Draw(int x, int y);

        public virtual ElementState ElementState { get; set; } = ElementState.Active;
    }
}
