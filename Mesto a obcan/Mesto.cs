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

        public Mesto(string nazovMesta)
        {
            NazovMesta = nazovMesta;
            obcania = new List<Obcan>();
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
        }
    }//NEMAM OBSOLUR
}
