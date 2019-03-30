using System;
using System.Collections.Generic;
using System.Linq;

namespace Lektion06
{
    public class ArrayLengthNotEqualException : Exception
    {
        public ArrayLengthNotEqualException()
        {
        }

        public ArrayLengthNotEqualException(string message)
            : base(message)
        {
        }

    }
    
    public class HandyMethods
    {
        // a. Write the generic methods Max and Min with type parameter T, parametrized
        // with a List<T>
        public T Max<T>(List<T> list) where T : IComparable<T>
        {
            return list.Max();
        }
        
        // b. Write a generic method copy with a type parameter T that takes two arguments
        //of type T[] and copies the content of one array to the other array. Throw an
        //    exception if the arrays have unequal lengths.
        public void Copy<T>(T[] arr1, T[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                throw new ArrayLengthNotEqualException("Ree");
            }

            int i = 0;
            foreach (var element in arr1)
            {
                arr2[i] = element;
                i++;
            }
            
        }
        
        // c. Write a generic method shuffle with a type parameter T that takes an argument
        // of type T[]. Permute the array using the following algorithm: Repeatedly
        // generate two random numbers i and j, where i and j must be valid array indices
        // and then swap the entry i with the entry j. Perform this operation n times where
        // n is the length of the array.
        public void Shuffle<T>(T[] Tarray)
        {
            Random rnd = new Random();
            int i = 0;
            int j = 0;
            int n = 0;
            
            while (n < Tarray.Length)
            {
                i = rnd.Next(0, Tarray.Length);
                j = rnd.Next(0, Tarray.Length);
                var temp = Tarray[i];
                Tarray[i] = Tarray[j];
                Tarray[j] = temp;
                n++;
            }
        }
        
    }
    
    public class Opgave1
    {
        public void Execute()
        {
           // Delopgave a)
           var hmethods = new HandyMethods();
           List<int> list = new List<int>
           {
               1,
               3,
               2,
               8,
               4,
               5
           };
           //var max = hmethods.Max(list);
           //Console.WriteLine(max);

           // Delopgave b)
           string[] arr1 = {"hej", "med", "dig"};
           string[] arr2 = {"velkommen", "tilbage", "!"};
           
           hmethods.Copy(arr1, arr2);
           //Console.WriteLine(arr2[1]);
           
           // Delopgave c)
           string[] arrShuffleMig = {"jeg", "er", "en", "sætning"};
           hmethods.Shuffle(arrShuffleMig);

           foreach (var element in arrShuffleMig)
           {
               Console.WriteLine(element);
           }
        }
    }
}