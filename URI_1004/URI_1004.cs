using System;
namespace URI1004
{
    internal static class URI
    {
        private static void Main(string[] args)
        {
            int A, B, PROD;

            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());

            PROD = A * B;

            Console.WriteLine("PROD = {0}", PROD);
        }
    }
}