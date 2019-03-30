using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Security.AccessControl;
using System.Windows;


namespace Lektion1
{
    class Program
    {
        // Konstanter til opgave 1 c
        public const long DAY = 86400000000000;
        public const long HOUR = 3600000000000;
        public const long MIN = 60000000000;
        public const long SEC = 1000000000;

        static void Main(string[] args)
        {
            //Opgave1();
            //Opgave3();
            //Opgave4();
            //Opgave5();
            //Opgave6();

            Console.ReadLine();
        }

        // Opgave 1
        static void Opgave1()
        {
            Console.WriteLine("Hello World");
            var result = FtoC(50f);
            Console.WriteLine(result);
            NanoToFull(100000000000);
            
        }

        // Fahrenheit to Celsius
        static float FtoC(float celsius)
        {
            return (celsius - 32) / 1.8000f;
        }

        // Konverter nano sekunder til Dage, timer, minutter og sekunder
        static void NanoToFull(long nanosec)
        {
            long days, hours, minutes, seconds;
            long daysRest, hoursRest, minutesRest;

            days = nanosec / DAY;
            daysRest = nanosec % DAY;

            hours = daysRest / HOUR;
            hoursRest = daysRest % HOUR;

            minutes = hoursRest / MIN;
            minutesRest = hoursRest % MIN;

            seconds = minutesRest % SEC;

            Console.WriteLine(days + " Days " + hours + " Hours " + minutes + " Minutes " + seconds + " Seconds");

        }

        // Opgave 2 + 3 bruger klasser Person og PersonPrinter
        static void Opgave3()
        {
            var jens = new Person("Jens", "Andersen") { Alder = 73, Fornavn = "Jens", Efternavn = "Andersen"};
            var bodil = new Person("Bodil", "Andersen") { Alder = 72, Fornavn = "Bodil", Efternavn = "Andersen"};

            var hollen = new Person("Hollen", "Hollensen") { Alder = 62, Fornavn = "Hollen", Efternavn = "Hollensen"  };
            var ulla = new Person("Ulla", "Andersen", jens, bodil) { Alder = 52, Fornavn = "Ulla", Efternavn = "Andersen" };

    
            var christoffer = new Person("Christoffer", "Hollensen", hollen, ulla) { Alder = 19, Fornavn = "Christoffer", Efternavn = "Hollensen" };

            var printer = new PersonPrinter();

            christoffer.Far = christoffer; // setter ingenting fordi value er lig med this

            printer.PrintDetails(christoffer);

            printer.PrintFamily(christoffer);
        }

        // Opgave 4 bruger klasse File
        static void Opgave4()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\Christoffer\Desktop\");
            FileInfo[] files = dirInfo.GetFiles();

            DirectoryInfo[] dirs = dirInfo.GetDirectories();

            // a
            foreach (var file in files)
            {
                Console.WriteLine(file.Name + " " + file.Length + " bytes");
            }

            // b
            foreach (var dir in dirs)
            {
                FileInfo[] filesInDir = dir.GetFiles();

                foreach (var file in filesInDir)
                {
                    Console.WriteLine(file.Name + " " + file.Length + " bytes");
                }
            }
        }

        // Opgave 5  sammenligning af referencer - bruger klasser Person
        static void Opgave5()
        {
            var refOne = new Person("Christoffer", "Hollensen");
            var refTwo = new Person("Christoffer", "Hollensen");
            var refThree = refOne; // aliasing


            // Denne sammenligning returner sand, fordi de er ens reference
            if (refOne == refThree)
            {
                Console.WriteLine("De er ==");
            }

            if (refOne.Equals(refThree))
            {
                Console.WriteLine("De er Equals()");
            }
        }

        // Opgave 6 - bruger klasser Vector2D til beregninger
        static void Opgave6()
        {
            // Definerer vectors
            var vectorA = new Vector(2, 4);
            var vectorB = new Vector(3, 4);

            // vector algebra handler
            var vectorAlgebra = new Vector2D();

            // Laver en ny vector til at opbevare resultatet
            Vector newVector = vectorAlgebra.SubVectors(vectorA, vectorB);
            // gammel: Vector newVector = vectorAlgebra.AddVectors(vectorA, vectorB);


            Console.WriteLine(newVector);
        }

    }
}
