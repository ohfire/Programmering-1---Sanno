using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_oop1
{
    internal class bil
    {
        private string märke;
        private string modell;
        private string färg;
        private int ålder;
        private int mil;

        public bil(string märke2, string modell2, string färg2, int ålder2, int mil2)
        {
            märke = märke2;
            modell = modell2;
            färg = färg2;
            ålder = ålder2;
            mil = mil2;
        }
        public void Mymetod()
        {
            Console.WriteLine(märke);
            Console.WriteLine(modell);
            Console.WriteLine(färg);
            Console.WriteLine(ålder);
            Console.WriteLine(mil);
        }
    }
}
