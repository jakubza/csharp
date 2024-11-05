using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesto_a_obcan
{
    public static class GeneratorObcanov
    {
        private static string[] mena = { "Igor", "Anna", "Peter", "Jana", "Martin", "Lucia", "Tomáš", "Eva", "Michal", "Zuzana", "Marek", "Katarína", "Andrej", "Lenka", "Patrik",
            "Monika", "Filip", "Veronika", "Richard", "Simona", "Róbert", "Mária", "Jakub", "Barbora", "Adam", "Dominika", "Lukáš", "Daniela", "Vladimír", "Nikola" };
        private static string[] programovaciejazyky = { "C#", "Python", "C++", "Java", "C" };
        public static Obcan GenerujObcana()
        {
            Random r = new Random();
            int pozicia = r.Next(mena.Length);
            string meno = mena[pozicia];
            int vek = r.Next(15, 116);
            Obcan obcan = new Obcan(meno, vek);
            return obcan;

        }
        public static Elekrikari GenerujJayzk()
        {
            Random r2 = new Random();
            int pozicia = r2.Next(mena.Length);
            string meno = mena[pozicia];
            int vek = r2.Next(15, 116);
            int pozicia2 = r2.Next(programovaciejazyky.Length);
            string programovacijazyk = programovaciejazyky[pozicia2];
            Elekrikari programator = new Elekrikari(meno,vek, programovacijazyk);
            return programator;
        }
    }
}
