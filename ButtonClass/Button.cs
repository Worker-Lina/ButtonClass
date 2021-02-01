using System;


namespace ButtonClass
{
    public delegate void ButtonActionDelegate(params object[] array);

    public class Button
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public string Text { get; set; }
        public string Color { get; set; }
        public ConsoleColor hBorderColor;

        public ButtonActionDelegate ButtonAction { get; set; }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public string Draw()
        {
            string s = "╔";
            string space = "";
            string temp = "";
            for (int i = 0; i < Width; i++)
            {
                space += " ";
                s += "═";
            }
            s += "╗" + "\n";
            string space2 = space;
            for (int i = 0; i < Height; i++)
            {
                if (i == 1)
                {
                    s += temp + "║" + Text +space2.Remove(0,Text.Length) + "║" + "\n";
                }
                else
                    s += temp + "║" + space + "║" + "\n";
            }

            s += temp + "╚";
            for (int i = 0; i < Width; i++)
                s += "═";

            s += "╝" + "\n";

            Console.ForegroundColor = hBorderColor;
            return s;
        }
    }
}
