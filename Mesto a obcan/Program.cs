﻿namespace Mesto_a_obcan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vytvorenie mesta
            Mesto Bratislava = new Mesto("Bratislava");

            //Obcania 
            
           

           /*while (Bratislava.obcania.Count < 31)
            {
                Obcan o = GeneratorObcanov.GenerujObcana();
                Bratislava.PridajObcanadomesta(o);
            }
            

            for (int i = 0; i < 31; i++)
            {
                Obcan o = GeneratorObcanov.GenerujObcana();
                Bratislava.PridajObcanadomesta(o);
            }*/
            
            while (Bratislava.Obcania.Count < 31)
            {
                Elekrikari o = GeneratorObcanov.GenerujJayzk();
                Bratislava.PridajObcanadomesta(o);
            }



            //Vypis obcanov Bratislavy
            Bratislava.VypisObcanov();   
            
           Console.WriteLine($" ___   __  ____________  ____  ___ _____   ___    ____ \r\n   /   | / / / /_  __/ __ \\/ __ )/   /__  /  /   |  / __ \\\r\n  / /| |/ / / / / / / / / / __  / /| | / /  / /| | / /_/ /\r\n / ___ / /_/ / / / / /_/ / /_/ / ___ |/ /__/ ___ |/ _, _/ \r\n/_/  |_\\____/ /_/  \\____/_____/_/  |_/____/_/  |_/_/ |_|






        }

    }
}