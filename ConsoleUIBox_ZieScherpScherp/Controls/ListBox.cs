using ConsoleUIBox_ZieScherpScherp.DrawingHelp;

namespace ConsoleUIBox_ZieScherpScherp.Controls
{
    public class ListBox : ItemsControl
    {

        public ListBox() : base(1, 1)
        {

        }

     
        public override int Height
        {
            get 
            {
                int height = 1;

                foreach (var item in Items)
                {
                    height += item.Height + 1;
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
                return maxW+2;
            }

        }



    }
}
