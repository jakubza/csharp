namespace Mesto_a_obcan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vytvorenie mesta
            Mesto Bratislava = new Mesto("Bratislava") ;
            
            //Obcania 
            Lekari lek = new Lekari("Imrich",vek : 25);
            Elekrikari ele = new Elekrikari( "Baca", 36, "medenny");
            SenorElektrikar sen = new SenorElektrikar("Sergej", 55, "medeny", 495916);

            Bratislava.PridajObcanadomesta(lek);
            Bratislava.PridajObcanadomesta(ele);
            Bratislava.PridajObcanadomesta(sen);



            //Vypis obcanov Bratislavy
            Bratislava.VypisObcanov();    
            
           

           

            

        }

    }
}