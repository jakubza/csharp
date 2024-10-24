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

            //Pridaj obcana do Blavy
            Bratislava.PridajObcanadomesta(obcan1);
            Bratislava.PridajObcanadomesta(obcan2);

            //Pridaj obcanov do Kosic
            Kosice.PridajObcanadomesta(obcan3);
            Kosice.PridajObcanadomesta(obcan4);

            //Vypis obcanov Bratislavy
            Bratislava.VypisObcanov();

            //Vypis obcanov Kosic
            Kosice.VypisObcanov();
        }

    }
}