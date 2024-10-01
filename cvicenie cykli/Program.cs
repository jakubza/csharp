using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
                //i = i + 10000;
                
                
                if (i == 10)
                {
                    break;
                }
               
            }
            
            
            
            /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }*/



            string[] names = { "Sam", "Tom", "Paulie", "Salieri" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine("zadaj cislo");
                int pocetOpakovani = int.Parse(Console.ReadLine());

            int b = 0;
            while (b < 5)
            {
                Console.WriteLine(i);
                b++;
            
            if (b == pocetOpakovani)
           
                break;
            }

            
        }


    }
}