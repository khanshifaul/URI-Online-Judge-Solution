using System;
namespace URI1003
{
    internal static class URI
    {
        private static void Main(string[] args)
        {
            int A, B, SOMA;

            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());

            SOMA = A + B;

            Console.WriteLine("SOMA = {0}", SOMA);
        }
    }
}
