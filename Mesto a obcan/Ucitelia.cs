using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesto_a_obcan
{
    internal class Ucitelia
    {
        public string meno { get; set; }
        public int vek { get; set; }

        public Ucitelia(string meno, int vek)
        {
            this.meno = meno;
            this.vek = vek;
        }

        public void Ucenie()
        {
            Console.WriteLine("Meno: " + meno + " Vek " + vek + " Uci");
        }
    }
}
