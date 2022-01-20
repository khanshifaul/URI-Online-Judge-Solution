using System;
namespace URI1006
{
    internal static class URI
    {
        private static void Main(string[] args)
        {
            double A, B, C, MEDIA;

            A = Convert.ToDouble(Console.ReadLine(), null);
            B = Convert.ToDouble(Console.ReadLine(), null);
            C = Convert.ToDouble(Console.ReadLine(), null);

            MEDIA = (2 * A + 3 * B + 5 * C) / (2 + 3 + 5);

            Console.WriteLine("MEDIA = {0:F1}", MEDIA);
        }
    }
}