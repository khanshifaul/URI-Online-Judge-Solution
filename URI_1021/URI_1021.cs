using System;
namespace URI1021
{
    internal static class URI
    {
        private static void Main(string[] args)
        {
            double N = Double.Parse(Console.ReadLine());
            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{(int)(N / 100)} nota(s) de R$ 100.00");
            N %= 100;

            Console.WriteLine($"{(int)(N / 50)} nota(s) de R$ 50.00");
            N %= 50;

            Console.WriteLine($"{(int)(N / 20)} nota(s) de R$ 20.00");
            N %= 20;

            Console.WriteLine($"{(int)(N / 10)} nota(s) de R$ 10.00");
            N %= 10;

            Console.WriteLine($"{(int)(N / 5)} nota(s) de R$ 5.00");
            N %= 5;

            Console.WriteLine($"{(int)(N / 2)} nota(s) de R$ 2.00");
            N %= 2;

            Console.WriteLine("MOEDAS:");

            Console.WriteLine($"{(int)(N)} moeda(s) de R$ 1.00");
            N = N % 1 * 100;

            Console.WriteLine($"{(int)(N / 50)} moeda(s) de R$ 0.50");
            N %= 50;

            Console.WriteLine($"{(int)(N / 25)} moeda(s) de R$ 0.25");
            N %= 25;

            Console.WriteLine($"{(int)(N / 10)} moeda(s) de R$ 0.10");
            N %= 10;

            Console.WriteLine($"{(int)(N / 5)} moeda(s) de R$ 0.05");
            N %= 5;

            Console.WriteLine($"{(int)N} moeda(s) de R$ 0.01");
        }
    }
}