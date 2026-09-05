using System;
using System.Collections.Generic;
using System.Text;

namespace F
{
    internal class Author
    {
        string AuthorData { get; set; }
        public Author(string author)
        {
            AuthorData = author;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(AuthorData);
        }
    }
}
