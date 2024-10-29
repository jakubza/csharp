using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesto_a_obcan
{
    public class SenorElektrikar : Elekrikari 
    {
        public int pocetkablov;
        public SenorElektrikar(string meno, int vek, string typkablu, int pocetkablov) : base(meno, vek, typkablu) 
        { 
           this.pocetkablov = pocetkablov; 
        }
        public new void VypisInfo()
        {
            Console.WriteLine("Meno: " + meno + " Vek " + vek + " Elektrikuje s" + typkablu + "Pocet kablov" + pocetkablov) ;
        }

    }
}
