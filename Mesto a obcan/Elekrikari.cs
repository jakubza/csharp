using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesto_a_obcan
{
    public class Elekrikari : Obcan
    {
        public string programovacijazyk;
       public Elekrikari(string meno, int vek, string programovacijazyk) : base(meno, vek)
        {
           this.programovacijazyk = programovacijazyk;
        }
        public override void VypisInfo()
        {
            Console.WriteLine("Meno: " + meno + " Vek " + vek + " " +  programovacijazyk);
        }
    }
}
