using System;
using System.Collections.Generic;

namespace Lektion06
{
    public class Pair<T>
    {
        public T First { get; set; }
        public T Second { get; set; }
    }

    public class Tuple<TItem1, TItem2>
    {
        public TItem1 Item1 { get; set; }
        public TItem2 Item2 { get; set; }
    }
    
    // åben, når det er en ny generisk type
    class OpenSub<U> : Pair<U>
    {
        
    }
    // lukket, når den nedarver med en bestemt type fx string
    class StringSub : Pair<string>
    {
        
    }
    
    // Selv-referende generiske typer
    class Person : IEquatable<Person>
    {
        public bool Equals(Person prs)
        {
            return true;
        }
    }

    class MultipleConstraints<T, U> 
        where T : struct
        where U : class
    {
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //var opg1 = new Opgave1();
            //opg1.Execute();
            var opg2 = new Opgave2();
            opg2.ExecuteOpgave();
        }
    }
}