using System;

namespace uppgift_oop1
{
    class program
    {
        static void Main(string[] args)
        {
            bil p = new bil("volvo", "v70", "mörkblå", 13, 25000);

            bil p2 = new bil("audi", "r8", "vit", 4, 5000);

            p.Mymetod();
            Console.WriteLine("");
            p2.Mymetod();
        }
    }
}
