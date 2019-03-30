using System;

namespace Lektion1
{
 

    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Alder;

        private Person _far;
        private Person _mor;

        public Person Far
        {
            get { return _far; }
            set
            {
                if (value != this)
                {
                    this._far = value;
                }
            }
        }

        public Person Mor
        {
            get { return _mor; }
            set
            {
                if (value != this)
                {
                    this._mor = value;
                }
            }
        }

        // Constructor
        public Person(string fornavn, string efternavn)
        {
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
        }

        // Constructor chaining
        public Person(string fornavn, string efternavn, Person far, Person mor) 
            : this(fornavn, efternavn)
        {
            this.Far = far;
            this.Mor = mor;
        }

    }
}
