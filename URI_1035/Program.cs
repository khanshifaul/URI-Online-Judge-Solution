using System;
namespace URI1035
{
    internal static class URI
    {
        private static void Main(string[] args)
        {
            string[] ABCD = Console.ReadLine().Split(' ');
            int A = int.Parse(ABCD[0]);
            int B = int.Parse(ABCD[1]);
            int C = int.Parse(ABCD[2]);
            int D = int.Parse(ABCD[3]);

            if ((B > C && D > A) && (C + D > A + B) && (C > 0 && D > 0))
            {

                Console.WriteLine("Valores aceitos");
            }
            else Console.WriteLine("Valores nao aceitos");
        }
    }
}