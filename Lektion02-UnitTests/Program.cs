using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion2
{
    class Program
    {
        static void Main(string[] args)
        {
            var strengArbejder = new OwnString();

            char[] minStreng = {'h', 'e', 'j', 't', 'e', 's', 't'};

            // eks 3 til 5, der skal være 3,4,5 ( end - start + 1 ) = ( 5 - 3 + 1 ) = 3
            // eks 3 til 8, der skal være 3,4,5,6,7,8 ( end - start + 1) = ( 8 - 3 + 1 ) = 6

            // starter på 0
            char[] result = strengArbejder.SubString(minStreng, 3, 5);

            foreach (var ch in result)
            {
                Console.WriteLine(ch);
            }
            

            Console.ReadLine();
        }
    }
}
