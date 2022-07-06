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
		

	     Console.WriteLine(KataRange.contains("[2,9]","(3,6)"));
            Console.WriteLine(KataRange.contains("[1,5]", "(7,9)"));

            List<int> index = KataRange.GetAll("[1,8)");

            foreach(int element in index)
            {
                Console.WriteLine(element);
            }

		
        }
    }
}
