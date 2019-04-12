using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

/* Noter til lektion 08 fra forelæsning:
 *Collection Interfaces:
 * Niv 1: IEnumerable kan kun løbes gennem
 * Niv 2: ICollection : IEnumerable kan man tilføje til fx List. List definerer dog orden som ICollection ikke gør.
 *     - Clear
 *     - CopyTo
 *     - Remove
 *     - etc
 * Niv 3a: List
 *     - List har en indekser i starten, så den starter på -1
 * Niv 3b: IDictionary
 *    - Mapping fra TKey til TValue
 *     - En collection af KeyValue pairs
 *     - Dictionary er et opslag overfor søgning
 *     - Man kan skrive sin egen indexer
 *     - ved public Asset this[int index]
 *  Klasser Niv 4: Stack<T> (bredde), Queue<T> (dybde), LinkedList<T>, HashSet<T>, List<T>, Dictionary<TKey, TValue>
 *
 *  Stack<T>
 *     - Peek
 *     - Pop
 *     - Push
 * Queue<T> (ligesom Stack bare omvendt)
 *     - Peek
 *     - Enqueue
 *     - Dequeue
 * LinkedList<T>
 *     - Lineær tid søgning (konstant tid)
 *     - Indsæt og fjern operationer er stort gratise, fordi der ikke er array implementation bagved.
 *     - Er en dobbelt kædet liste
 *     - Man kan lave operationer forfra og bagfra
 * ISet<T>(interface) og HashSet<T>(implementation)
 *     - a.UnionWith
 *     - a.IntersectWith
 *     - etc.
 *
 *  Brug klasse som en Key i et dictionary.
 *  Find ud af hvornår 2 keys er ens.
 *  Reference-lighed og værdi-lighed
 *
 * Equals implementeres typisk som Reference lighed (adresserne)
 * Equals kan eksempelvis overrides ved CPR, fordi ingen personer har samme CPR.
 * 
 * Implementering af Equals(object obj).
 * GetHashCode() - deres Hash Code skal også være ens for at være ens fx længden 3 -2, kan aldrig være ens
 * XOR er okay til distribution
 *
 * XOR baseres på værdien fx FirstName, LastName, Weight, Age. Man kan XOR på FirstName.GetHashCode()
 *
 * Tjek-procedure ved bool Equals
 *  - check for null - false
 *  - check for reference-lighed - true
 *  - check for ækvivalente typer
 *  - Check for ækvivalente has-koder
 *  - check for Base.Equals
 *  - check med Equals
 * Equals og GetHash bør kun baseres på ReadOnly værdier.
 *
 * LINQ
 *  Query operator kædes sammen (indre og ydre)
 *  Implementeret som extension methods
 *  
 * 
 * Ekstra:
 * IEnumerable<T>
 * Man kan løbe over sit Enumerable med en Enumerator
 * public IEnumerator enumerator = ac.GetEnumerator()
 * 
 */

namespace Lektion08
{
    class Program
    {   
        public class MyList<TKey, TValue> : SortedList
        {
            

        }
        
        public class Asset : IComparable<Asset>
        {
            public string Name { get; set; }
            
            public int CompareTo(Asset asset)
            {
                return this.Name.CompareTo(asset);
            }
            
        }
        
        static void Main(string[] args)
        {

            var list = new SortedList();
            list.Add("01", "Texture.png");
            list.Add("02", "Overworld.mp3");
            
            var listAssets = new List<Asset>();
            
            
            // get a collection of the keys. 
            ICollection key = list.Keys;

            foreach (var k in key)
            {
                
            }


            IDictionary<string, Asset> assetDict = new Dictionary<string, Asset>();
            Asset asset1 = new Asset() { Name = "HiRes_Ground_1024x1024"};
            assetDict.Add("Ground", asset1);
            
            // Undgå exception ved ekstrahering af Value
            if (assetDict.ContainsKey("Ground"))
            {
                
            }
            
            // Iterering af Dictionary
            foreach (KeyValuePair<string, Asset> kvp in assetDict)
            {
                // Har keyvalue pair en ToString()?
                //Console.WriteLine(kvp);
            }
            
            // LINQ er metoder som findes på IEnumerable
            //var strings = new List<string>();
            //strings.Add("Hello");
            //strings.Add(",");
            //strings.Add("Welcome to");
            //strings.Add("Here");

            //var res = strings
            //    .Where(p => p.Contains("el"));
            
            // Select kan bruges til at projicere datatypen til noget andet

            //foreach (var s in strings)
            //{
            //    Console.WriteLine(s);
            //}

            // Select med Anonyme typer
            // new er i vores lambda expression

            // Partioneringsoperatorer
            // Aggregeringsoperatorer
            // Mængdeoperatorer

            //var opg1 = new Opgave1();
            //opg1.Execute_Opgave();
            
            //var opg2 = new Opgave2();
            //opg2.Execute_Opgave();

            var opg3 = new Opgave3();
            opg3.Execute_Opgave();
        }
    }
}