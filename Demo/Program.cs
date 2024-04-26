using ConsoleUIBox_ZieScherpScherp;
using ConsoleUIBox_ZieScherpScherp.Controls;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false; //todo naar drawing lib verhuizen?

            ListBox buttons = new ListBox();

            Button[] toAdd = {
                new Button("Item 1", null, 20, 3),
                new Button("Change but 1", () => (buttons.Items[0] as Button).Text = "Hey!", 20, 3),
                new Button("Remove me", ()=>buttons.Items.RemoveAt(2), 20, 3),
                new Button("Close", () => { Console.Clear(); Environment.Exit(0); }, 20, 3),

            };


            buttons.Items.AddRange(toAdd);
            buttons.Items.Add(new CheckBox("Check me", false));

            int sel = 0;
            buttons.Items[sel].ElementState = ElementState.Selected;
            while (true)
            {
                buttons.Draw(5, 6);

                buttons.Items[sel].ElementState = ElementState.Active;

                var choice = Console.ReadKey().Key;
                Console.Clear();
                switch (choice)
                {
                    case ConsoleKey.UpArrow:
                        sel = (sel + buttons.Items.Count - 1) % buttons.Items.Count;

                        break;
                    case ConsoleKey.DownArrow:
                        sel = (sel + 1) % buttons.Items.Count;

                        break;
                    case ConsoleKey.Enter:
                        (buttons.Items[sel] as Button).Click();
                        break;
                }
                buttons.Items[sel].ElementState = ElementState.Selected;

            }

            Console.SetCursorPosition(1, 20);
        }
    }
}
