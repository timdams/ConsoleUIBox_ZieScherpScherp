
using ConsoleUIBox_ZieScherpScherp.DrawingHelp;

namespace ConsoleUIBox_ZieScherpScherp
{
  
    
    public abstract class ContentControl: Control
    {
        protected ContentControl(int w, int h) : base(w, h)
        {
        }

        public override ElementState ElementState
        {
            get => base.ElementState;
            set
            {
                base.ElementState = value;
                if(Content!=null)
                    Content.ElementState = base.ElementState;
            }
        }
        public Control Content { get; set; }

        public override void DrawAction(int x, int y)
        {
            
            Content?.DrawAction(x, y);
        }

    }
}
