using System;
using System.Collections.Generic;
using System.Text;

namespace F
{
    internal class Book
    {
        readonly Title title;
        readonly Author author;
        readonly Content content;

        public Book (string title, string author, string content)
        {
            this.title = new(title);
            this.author = new(author);
            this.content = new(content);

        }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
