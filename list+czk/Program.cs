using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
            List<string> listnames = new List<string>();
            while (true)
            {
                Console.WriteLine("\nZadaj meno");
                var meno = Console.ReadLine();
                Console.Clear();
                if (meno == "quit")
                {
                    break;
                }
                else
                {
                    listnames.Add(meno);
                }

                Console.WriteLine("Zoznam mien");
                foreach (var meno2 in listnames)
                {
                   Console.WriteLine(meno2);
                }
            }
           
        }
    }
}
