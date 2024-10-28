using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesto_a_obcan
{
    internal class Elekrikari
    {
        public string meno { get; set; }
        public int vek { get; set; }

        public Elekrikari(string meno, int vek)
        {
            this.meno = meno;
            this.vek = vek;
        }

        public void Elektrikovanie()
        {
            Console.WriteLine("Meno: " + meno + " Vek " + vek + " Elektrikuje");
        }
    }
}
