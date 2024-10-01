using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadaj meno");
           

            List<string> listnames = new List<string>();
            listnames.Add(Console.ReadLine());
            listnames.Add(Console.ReadLine());
            listnames.Add(Console.ReadLine());
            listnames.Add(Console.ReadLine());

            foreach (string name in listnames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
