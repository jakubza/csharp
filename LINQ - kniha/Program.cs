using System.Collections.Generic;

namespace LINQ___kniha
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Kniha> Knihy = new List<Kniha>()
            {
            new Kniha { Autor = "Anna Maria", RokVydania = 2011, JePreDeti = true },
            new Kniha { Autor = "Anna Hruskova",RokVydania = 2009, JePreDeti = false },
            new Kniha { Autor = "Bob", RokVydania = 2022, JePreDeti = true },
            new Kniha { Autor = "Charlie", RokVydania = 2018, JePreDeti = true },
            new Kniha { Autor = "Bob", RokVydania = 2020 , JePreDeti = false},
            };


            List<Kniha> knihaJePreDeti = Knihy.Where(kniha => kniha.JePreDeti == true).ToList();
            foreach (Kniha kniha in knihaJePreDeti)
            {
                Console.WriteLine($" Autor: {kniha.Autor}, {kniha.RokVydania}. Je pre deti ? { kniha.JePreDeti}");
            }
        }

        
    }
}