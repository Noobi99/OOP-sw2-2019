using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Linq;

namespace Lektion07
{
    // Opgave 2
    public delegate string StringJoin(string param1, string param2);
    // Opgave 5
    // Define a generic delgate type named Join with a single type parameter T, with two parameters
    // and return-type of type T.
    public delegate T Join<T>(T param1, T param2);
    
    
    
    public class Program
    {
        // Opgave 2
        public static string ConcatString(string l, string r) { return l + r; }
        // Opgave 3
        public static string Join3(string l, string r, string w, StringJoin str)
        {
            string res = str(l, r);
            return str(res, w);
        }
        // Opgave 4
        // Define a method JoinAllStrings, parameterized by a list of strings and a
        // StringJoin, which joins all strings in the list from left to right. For example:
        public static string JoinAllStrings(List<string> strings, StringJoin str)
        {
            var res = "";
            while (strings.Count > 1)
            {
                strings[0] = str(strings[0], strings[1]);
                strings.RemoveAt(1);   
            }
            return strings[0];
        }
        
        // Opgave 5
        //Use the Join delegate to implement a generic method JoinList which as the
        // JoinAll method, joins all elements in the list, as defined by the Join
        // parameter. Examples:
        public static T JoinList<T>(List<T> lst, Join<T> join)
        {
            T res = lst[0];
            return res;
        }
        
        // Opgave 6
        public static bool Exists<T>(Predicate<T> f, T[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (f(a[i]))
                {
                    return true;
                }
            }
            return false;
        }
        
        // Opgave 7
        public static T twice<T>(Func<T, T> f, T v)
        {
            var temp = f(v);
            return f(temp);
        }
        
        static void Main(string[] args)
        {
            // Opgave 2
            StringJoin str;
            str = ConcatString;
            var result = str("hello", "delegates");
            Console.WriteLine(result);
            
            // Opgave 3
            /*
            string res1 = Join3("a", "b", "c", (l, r) => l + r); //abc
            string res2 = Join3("a", "b", "c", (l, r) => l + "." + r); //a.b.c
            string res3 = Join3("a", "b", "c", (l, r) => l); // a
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            */

            // Opgave 4
            var listStrings = new List<string>();
            listStrings.Add("hej");
            listStrings.Add("med");
            listStrings.Add("dig");

            var res1 = JoinAllStrings(new List<string> {"a", "b", "c", "d"}, (l, r) => l + "." + r); // a.b.c.d
            var res2 = JoinAllStrings(new List<string> {"a", "b", "c", "d"}, (l, r) => l + r); // abcd
            var res3 = JoinAllStrings(new List<string> {"a", "b", "c", "d"}, (l, r) => r); // d
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);

            // Opgave 5
            //5. Define a generic delegate type named Join with a single type parameter T, with two parameters
            //and return-type of type T.
            //    d. Use the Join delegate to implement a generic method JoinList which as the
            //    JoinAll method, joins all elements in the list, as defined by the Join
            //    parameter. Examples:
            
            
            JoinList(new List<int> {1, 2, 3, 4}, (a, b) => a + b); // 10
            JoinList(new List<int> {1, 2, 3, 4}, (a, b) => a * b); // 24
            JoinList<string>(new List<string> {"a", "b", "c", "d"}, (l, r) => l + "." + r); // a.b.c.d
            
            // Opgave 6
            // 6. Write a generic method Exists(Predicate<T> f, T[] a) that takes a type parameter T and two
            // arguments: a unary lambda expression f and an array a of type T. The method should return true
            // if the array contains an element for which the predicate evaluates to true. Otherwise, it should
            // return false
            Predicate<int> predicate = x => x > 20;

            int[] arr = {10, 21, 15, 2, 8, 9};
            
            var res = Exists(predicate, arr);

            Console.WriteLine(res);
            
            // Opgave 7
            // 7. Write a generic method twice(DELEGATETYPE f, T v) with type parameter T and two arguments:
            // a DELEGATETYPE from the standard library f and a value v of type T. The method should return
            // the result of applying f twice to the argument. For example, twice(x -> x * 2, 1) = 4. Choose the
            // appropriate type as DELEGATETYPE. See hint on last page. i
            int newInt = twice(x => x * 2, 1);
            string newStr = twice(x => "asd" + x, "Test");
            
            Console.WriteLine(newStr);
            
            // Opgave 7 reworked
            var reworkedRes = twiceReworked(( x,  y) => "asd" + 123.ToString(), "Hej");
            Console.WriteLine(reworkedRes);
        }
        
        // Opgave 7
        public static T twiceReworked<T>(Func<T, T, T> f, T v)
        {
            var temp = f(v, v);
            return f(v, v);
        }
        
    }
}