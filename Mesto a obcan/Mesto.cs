using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesto_a_obcan
{
    internal class Mesto
    {
        public string NazovMesta { get; set; }
        public List<Obcan> obcania { get; set; }
        public List<Lekari> lekari { get; set; }
        public List<Ucitelia> ucitelia { get; set; }
        public List<Elekrikari> elektrikari { get; set; }
        public Mesto(string nazovMesta)
        {
            NazovMesta = nazovMesta;
            obcania = new List<Obcan>();
            lekari = new List<Lekari>();
            ucitelia = new List<Ucitelia>();
            elektrikari = new List<Elekrikari>();
        }
        public void PridajElektrikaraDeMesta (Elekrikari elektrikar)
        {
            elektrikari.Add(elektrikar);
        }
        public void PridajUcitelaDoMesta(Ucitelia ucitel)
        {
            ucitelia.Add(ucitel);
        }
        

        public void Pridajlekaradomesta(Lekari lekar)
        {
            lekari.Add(lekar);
        }
        
        
        public void PridajObcanadomesta(Obcan obcan)
        {
            obcania.Add(obcan);
        }
        public void VypisObcanov()
        {
            Console.WriteLine("Obcania mesta " + NazovMesta);
            foreach (var obcan in obcania) 
            {
                obcan.Vipisinfo();
            }
            Console.WriteLine("\n");
            foreach (var lekar in lekari)
            {
                lekar.Liecenie();
            }
            Console.WriteLine("\n");
            foreach (var ucitel in ucitelia)
            {
                ucitel.Ucenie();
            }
            Console.WriteLine("\n");
            foreach (var elektrikar in elektrikari )
            {
                elektrikar.Elektrikovanie();
            }
            Console.WriteLine("\n");

        }
    }
}
