namespace Mesto_a_obcan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vytvorenie mesta
            Mesto Bratislava = new Mesto("Bratislava") ;
            Mesto Kosice = new Mesto("Kosice ");

            //vytvorenie obcanov Blavy 
            Obcan obcan1 = new Obcan("Dezider Horvat",36);
            Obcan obcan2 = new Obcan("Tatiana Kovacova", 59);
            
            //Vytorenie Obcanov Kosic
            Obcan obcan3 = new Obcan("Karol Horak", 18);
            Obcan obcan4 = new Obcan("Simon Cellar", 55);

            //Vytvorenie Lekarov Blavy
            Lekari lekar1 = new Lekari("Pavol Kristus", 46);
            Lekari lekar2 = new Lekari("Eruk Kartmen", 35);

            //Vytvorenie Lekarov Kosic
            Lekari lekar3 = new Lekari("Pavol Kristus", 46);
            Lekari lekar4 = new Lekari("Eruk Kartmen", 35);

            //Vypis Ucitelov Blavy
            Ucitelia ucitel1 = new Ucitelia("Placeholder", 0);
            Ucitelia ucitel2 = new Ucitelia("Placeholder", 0);

            Ucitelia ucitel3 = new Ucitelia("Placeholder", 0);
            Ucitelia ucitel4 = new Ucitelia("Placeholder", 0);


            //Pridaj obcana do Blavy
            Bratislava.PridajObcanadomesta(obcan1);
            Bratislava.PridajObcanadomesta(obcan2);

            //Pridaj Lekara do Blavy
            Bratislava.Pridajlekaradomesta(lekar1);
            Bratislava.Pridajlekaradomesta(lekar2);

            //
            Bratislava.PridajUcitelaDoMesta(ucitel1);
            Bratislava.PridajUcitelaDoMesta(ucitel2);

            //Pridaj obcanov do Kosic
            Kosice.PridajObcanadomesta(obcan3);
            Kosice.PridajObcanadomesta(obcan4);

            //Pridaj Lekarov do Kosic
            Kosice.Pridajlekaradomesta(lekar3);
            Kosice.Pridajlekaradomesta(lekar4);


            Kosice.PridajUcitelaDoMesta(ucitel3);
            Kosice.PridajUcitelaDoMesta(ucitel4);


            //Vypis obcanov Bratislavy
            Bratislava.VypisObcanov();

      
            //Vypis obcanov Kosic
            Kosice.VypisObcanov();

           

           

            

        }

    }
}