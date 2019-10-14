using System;
using System.Collections.Generic;
namespace Csharpforeach
{
    class Names
    {
        private string first, last;

        public Names(String f, String l)
        {
            first = f;
            last = l;
        }

        public string First
        {
            get
            {
                return first;
            }
            set
            {
                first = value;
            }
        }

        public string Last
        {
            get
            {
                return last;
            }
            set
            {
                last = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>();
            strings.Add("Mick");
            strings.Add("George");
            strings.Add("Saul");
            strings.Add("Nikki");
            strings.Add("Lyla");
            strings.Add("Daphne");
            foreach(string name in strings)
                Console.WriteLine("Hello {0}", name);

            
            Console.WriteLine("==========================");

            List<Names> names = new List<Names>();
            Names p1 = new Names("Mike", "Wazowski");
            Names p2 = new Names("James", "Hart");
            Names p3 = new Names("Anna", "Steinberg");
            Names p4 = new Names("Milla", "Hill");
            Names p5 = new Names("Luke", "Star");
            Names p6 = new Names("Phil", "Blane");
            names.Add(p1);
            names.Add(p2);
            names.Add(p3);
            names.Add(p4);
            names.Add(p5);
            names.Add(p6);

            foreach (Names name in names)
                Console.WriteLine("Hello {0} {1}", name.First, name.Last);
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
