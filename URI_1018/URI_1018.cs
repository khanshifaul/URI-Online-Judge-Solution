using System;
namespace URI1018
{
    internal static class URI
    {
        private static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(N);
            int i = 0;
            while (N >= 100)
            {
                N -= 100;
                i++;
            }
            Console.WriteLine("{0} nota(s) de R$ 100,00", i);
            i = 0;
            while (N >= 50)
            {
                N -= 50;
                i++;
            }
            Console.WriteLine("{0} nota(s) de R$ 50,00", i);
            i = 0;
            while (N >= 20)
            {
                N -= 20;
                i++;
            }
            Console.WriteLine("{0} nota(s) de R$ 20,00", i);
            i = 0;
            while (N >= 10)
            {
                N -= 10;
                i++;
            }
            Console.WriteLine("{0} nota(s) de R$ 10,00", i);
            i = 0;
            while (N >= 5)
            {
                N -= 5;
                i++;
            }
            Console.WriteLine("{0} nota(s) de R$ 5,00", i);
            i = 0;
            while (N >= 2)
            {
                N -= 2;
                i++;
            }
            Console.WriteLine("{0} nota(s) de R$ 2,00", i);
            i = 0;
            while (N >= 1)
            {
                N -= 1;
                i++;
            }
            Console.WriteLine("{0} nota(s) de R$ 1,00", i);
        }
    }
}