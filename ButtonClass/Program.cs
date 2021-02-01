using System;

namespace ButtonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var button = new Button
            {
                Width = 9,
                Height = 3,
                Text = "Click",
                hBorderColor = ConsoleColor.Red,
                ButtonAction = new ButtonActionDelegate(Console.WriteLine)
            };

            button.ButtonAction += new ButtonActionDelegate(Save);
            Console.WriteLine(button.Draw());
        }

        private static void Save(object data)
        {

        }

    }
}
