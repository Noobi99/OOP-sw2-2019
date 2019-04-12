using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace Lektion08
{
    public class SortedList<T> : ICollection<T> where T : IComparable
    {
        private T[] array;
        
        //private List<T> list;
        
        public IEnumerator<T> GetEnumerator()
        {
            throw new Exception();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new Exception();
        }

        public IEnumerator<T> GetElementsReversed()
        {
            throw new Exception();
        }

        public void Add(T item)
        {
            if (item is IComparable)
            {

            }
            else
            {
                Console.WriteLine("Not a comparable item");
            }
        }

        public void Clear()
        {
            throw new Exception();
        }

        public bool Contains(T item)
        {
            throw new Exception();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            
        }

        public bool Remove(T item)
        {
            throw new Exception();
        }

        public int Count { get; }
        public bool IsReadOnly { get; }
        
    }

    public class Person : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            return Name.CompareTo(((Person) obj).Name);
        }
    }

    public class Opgave1
    {
        public void Execute_Opgave()
        {
            var slist = new SortedList<Person>();
            Person christoffer = new Person() {Name = "Christoffer", Age = 19};
            Person torben = new Person() {Name = "Torben", Age = 20};

            
            slist.Add(christoffer);
            slist.Add(torben);

            foreach (var item in slist)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}