using System;

namespace kataRangePackage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(KataR.KataRange.overlaps("[3,6]", "[4, 7]"));
            Console.WriteLine(KataR.KataRange.overlaps("[1,3]", "[4, 7]"));

            Console.WriteLine(KataR.KataRange.equals("(3,7)", "(3,7)"));
            Console.WriteLine(KataR.KataRange.equals("(3,7)", "(3,9)"));
        }
    }
}
