using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion1
{
    class PersonPrinter
    {
        public void PrintDetails(Person person)
        {
            Console.WriteLine(person.Fornavn + " " + person.Efternavn + ", " + person.Alder);
        }

        public void PrintFamily(Person person) { 

            PrintDetails(person);

            if (person.Far != null)
            {
                PrintFamily(person.Far);
            }

            if (person.Mor != null)
            {
                PrintFamily(person.Mor);
            }


        }

    }
}
