using System;
using System.Threading.Tasks;

namespace Lektion06
{
    // 2. Write a class Pair with two type parameters T1 and T2 to represent a pair of values (i.e.
    // the class should have two fields of type T1 and T2). Add an appropriate constructor and
    // getters. Do not add any setters, as the class should be immutable!
    public class Pair<T1, T2>
    {
        public T1 First { get; }
        public T2 Second { get; }

        public Pair(T1 input1, T2 input2)
        {
            First = input1;
            Second = input2;
        }

        public void PrintPair()
        {
            Console.WriteLine(First + "\n" + Second);
        }
        
         // 3. Add a method swap to the Pair class. The swap method should return a new pair where
         // the first component becomes the second component and vice versa. For example, for
         // the pair (true, 42) the method should return (42, true). (Hint: You will have to swap the
         // type parameters in the return type.)
         public Pair<T2, T1> Swap()
         {
             var newPair = new Pair<T2, T1>(Second, First);
             return newPair;
         }
         
         //   4. Add methods setFst and setSnd to the Pair class. Each method should take a type
         //   parameter C and return a new pair where the appropriate component has been
         //   updated. For example, calling setFst with the integer 42 on the pair (true, "Hello World")
         //   should return (42, "Hello World").
         public Pair<C, T2> SetFirst<C>(C comp)
         {
             var newPair = new Pair<C, T2>(comp, Second);   
             return newPair;
         }
         
    }

    public class Opgave2
    {
        public void ExecuteOpgave()
        {
            string minString = "Hej";
            int minInt = 42;
            var z = new Pair<string, int>(minString, minInt);
            z.PrintPair();

            var y = z.Swap();
            y.PrintPair();
            
            int nyFirst = 23;
            var x = z.SetFirst(nyFirst);
            x.PrintPair();
            
        }
        
    }
   
}