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

        public Mesto(string nazovMesta)
        {
            NazovMesta = nazovMesta;
            obcania = new List<Obcan>();
            lekari = new List<Lekari>();
            ucitelia = new List<Ucitelia>();
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
            foreach (var ucitel in ucitelia)
            {
                ucitel.Ucenie();
            }



        }
    }
}
