using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUIBox_ZieScherpScherp.Controls.NotImplemented
{
    internal class TextBox: TextBlock
    {
        public TextBox(string text) : base(text)
        {
        }

        public void ChangeText(string newText)
        {
            Text = newText;
        }
    }
}
