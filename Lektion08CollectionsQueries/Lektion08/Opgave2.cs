using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace Lektion08
{
    public class Opgave2
    {


        public void Execute_Opgave()
        {
            List<int> numbers = new List<int>();
            Random r = new Random();
            int randomNum = 0;
            
            for (int i = 1; i < 20; i++)
            {
                randomNum = r.Next(0, 100); //random number between 0 and 100
                numbers.Add(randomNum);
            }
            
            // a. Find all elements that are multiples of the value of an outer variable.
            int outerVar = 3;
            var multiples = numbers
                .Where(p => p % 2 == 0);
            
            // b. Find all elements between MAX and MIN as specified by two outer variables (e.g., all
            // numbers between 20 and 40).
            int Max = 30;
            int Min = 10;
            var elementsMaxMin = numbers
                .Where(p => p > Min && p < Max);
            
            // c. Return the greatest number between MAX and MIN (e.g, the number 38 if MIN=20,
            // MAX=40)
            var elementsMaxMinGreatest = numbers
                .Where(p => p > Min && p < Max)
                .Select(p => p)
                .Max();

            Console.WriteLine(elementsMaxMinGreatest);
            
            // d. Multiply all elements with a given value as specified by an outer variable
            int multiplier = 2;
            var multiplyAll = numbers
                .Select(p => p * multiplier);
            
            // e. Order the elements in descending order.
            var descending = numbers
                .OrderByDescending(p => p)
                .ToList();
            
            // f. Combine 2, 4, and 5 into one expression.
            //var combineTwo 
            
            // Tester
            foreach (var num in descending)
            {
                Console.WriteLine(num);
            }
        }
        
    }
}