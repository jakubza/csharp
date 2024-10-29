using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesto_a_obcan
{
    public class Obcan
    {
        public string meno { get; set; }
        public int vek { get; set; }

        public Obcan(string meno, int vek)
        {
            this.meno = meno;
            this.vek = vek;
        }
        public void Vipisinfo()
        {
            Console.WriteLine("Meno: " + meno);
        }
         
        public void VypisVek()
        {
            Console.WriteLine("Vek" + vek);
        }
    }
}
