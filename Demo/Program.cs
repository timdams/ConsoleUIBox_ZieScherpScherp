using ConsoleUIBox_ZieScherpScherp.BaseAbstractControls;
using ConsoleUIBox_ZieScherpScherp.Controls;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false; //todo naar drawing lib verhuizen?


            Window mainWindow = new Window(Console.WindowWidth - 3, Console.WindowHeight - 3, "Cursed WPF");

            

            ListBox buttons = new ListBox();
            mainWindow.Content = buttons;
            Button[] toAdd = {
                new Button(new TextBlock("Open window"), TestWindow, 20,3),
                new Button(new TextBlock("Change but 1"), () =>( (buttons.Items[0] as ContentControl).Content as TextBlock).Text = "Hey!", 20, 3),
                new Button(new TextBlock("remove me"), ()=>buttons.Items.RemoveAt(2), 20, 3),
                new Button(new TextBlock("Close me"), () => { Console.Clear(); Environment.Exit(0); }, 20, 3),

            };

          

            buttons.Items.AddRange(toAdd);
            buttons.Items.Add(new RadioButton(new TextBlock("Check me"), false));


            mainWindow.Draw(1, 1);

            Console.ReadKey();

            int sel = 0;
            buttons.Items[sel].ElementState = ElementState.Selected;
            while (true)
            {
                Console.Clear();
                mainWindow.Draw(1, 1);

                buttons.Items[sel].ElementState = ElementState.Active;

                var choice = Console.ReadKey().Key;
                
                switch (choice)
                {
                    case ConsoleKey.UpArrow:
                        sel = (sel + buttons.Items.Count - 1) % buttons.Items.Count;

                        break;
                    case ConsoleKey.DownArrow:
                        sel = (sel + 1) % buttons.Items.Count;

                        break;
                    case ConsoleKey.Enter:
                        buttons.Items[sel].Click();
                        break;
                }
                buttons.Items[sel].ElementState = ElementState.Selected;
               
            }

            Console.SetCursorPosition(1, 20);
        }

        public static void TestWindow()
        {
            Window about = new Window(10, 10, "About");
            about.DrawAction(10, 10);
            Console.ReadKey();
        }
    }
}
