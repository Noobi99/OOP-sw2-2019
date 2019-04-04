using System.IO;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Lektion07
{
    // Delegate typer
    delegate void LogDelegate(string s);
    delegate string NewDelegate(string s);
    
    // Generisk delegate (bruges for at undgå genbrug af delegate definitioner)
  
    public class OldProgram
    {
        static FileStream fs;
        static StreamWriter sw;
        
        // Methods matching delegate
        public static void PrintToConsole(string s)
        {
            Console.WriteLine(s);
        }

        public static void PrintToFile(string s)
        {
            fs = new FileStream("/home/christoffer/testing/dinmor.txt",
            FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        
        // Entry
        static void MainOld(string[] args)
        {
            LogDelegate logDelegate;
            //LogDelegate consoleLog = new LogDelegate(PrintToConsole); Kan skrives:
            LogDelegate consoleLog = PrintToConsole;
            LogDelegate fileLog = new LogDelegate(PrintToFile);

            // Delegate-aritmetik
            logDelegate = consoleLog;
            logDelegate += fileLog;


            logDelegate("Test");
            
            // Lambda Expression test
            NewDelegate l;
            l = v => "asd" + v;

            // Kald af delegates som vi ikke ved om er initialiseret
            if (l != null)
            {
                Console.WriteLine(l("test"));
            }
            
            // Expression syntax - Nyt i C# 7.0
            double Bar(int i) => i * 2;

            // Generisk delegateerklæring
            //delegate bool Predicate<int T>(T obj);
            // in forlader aldrig delegate, disse keywords dokumenterer hvilke vej parametre går
          
            // Indbyggede generiske delegate Action<> og Func<> op til 16 parametere, så vi behøver ikke egne generisk delegate
            // Action<> eksempel, peger alt på void som returtype
            Action<string> write = Console.WriteLine;
            write("Action<> test");

            // Func<> fx: Func<param1, param2, return> 
            // Predicate<> eksisterer også
            // Converter<> eksisterer også

            // Foretrukne metode at skrive på
            Func<double, double> ultra = val => .5 * val;
            
            // anden metode at skrive anonyme metoder på - absolut ikke fortrukken
            Func<double, double> delegateSyntax = delegate(double val) { return .5 * val; };
            
            // Lambda udtryk med ydre variable(closures)
            int power = 10; // closure
            Func<double, double> super = n => Math.Pow(n, power);

            // Andet ydre variable eksempel
            Func<int> inc = Incrementer();
            Console.WriteLine(inc());
            Console.WriteLine(inc());
            
            // Events (mangler)
            //event LogDelegate log
                
            // Traversering af invokationsliste (mangler)
            // kan bruges til fejlhåndtering
            
        }

        public static Func<int> Incrementer()
        {
            int i = 1;
            return () => i++;
        }
        
    }
}