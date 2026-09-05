using System;
using System.Collections.Generic;
using System.Text;

namespace F
{
    internal class Title
    {
        string TitleData { get; set; }
        public Title(string title)
        {
            TitleData = title;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(TitleData);
        }
    }
}
