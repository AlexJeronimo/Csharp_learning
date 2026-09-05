using System;
using System.Collections.Generic;
using System.Text;

namespace F
{
    internal class Content
    {
        string ContentData { get; set; }
        public Content(string content)
        {
            ContentData = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(ContentData);
        }
    }
}
