using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleUIBox_ZieScherpScherp.BaseAbstractControls
{
    public class ToggleControl : ContentControl
    {
        public bool IsChecked { get; private set; }
        public ToggleControl(ContentControl text, bool startStateChecked) : base(text.Width + 4, 1)
        {
            Content = text;
            OnClick = ChangeChecked;
            IsChecked = startStateChecked;
        }
        public virtual void ChangeChecked()
        {
            IsChecked = !IsChecked;
        }
    }
}
