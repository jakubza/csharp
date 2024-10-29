using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesto_a_obcan
{
    public class Elekrikari : Obcan
    {
        public string typkablu;
       public Elekrikari(string meno, int vek, string typkablu) : base(meno, vek)
        {
            this.typkablu = typkablu;
        }
        public new void VypisInfo()
        {
            Console.WriteLine("Meno: " + meno + " Vek " + vek + " Elektrikuje s" + typkablu);
        }
    }
}
