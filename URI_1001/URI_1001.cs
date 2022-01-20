using System;
namespace URI1001
{
    internal static class URI
    {
        private static void Main(string[] args)
        {
            int A, B, X;

            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());

            X = A + B;

            Console.WriteLine("X = {0}", X);
        }
    }
}
