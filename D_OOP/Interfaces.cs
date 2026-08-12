using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace D_OOP
{
    public interface IBaseCollection
    {
        void Add(object obj);
        void Remove(object obj);

        public virtual void Clear()
        {
            Console.WriteLine("Default implementation in Interface not implemented\\overrided in class");
        }
    }


    public static class BaseCollectionExtension
    {
        public static void AddRange(this IBaseCollection collection, IEnumerable<object> objects)
        {
            foreach (var item in objects)
            {
                collection.Add(item);
            }
        }
    }
    public class BaseList : IBaseCollection
    {
        private object[] items;
        private int counter = 0;

        public BaseList(int initialCapacity)
        {
            items = new object[initialCapacity];
        }

        public void Add(object obj)
        {
            items[counter] = obj;
            counter++;
        }

        public void Remove(object obj)
        {
            items[counter] = null;
            counter--;
        }
    }
}
