namespace URI1013
{
    internal static class URI
    {
        private static void Main(string[] args)
        {
            int a, b, c;
            string[] abs = Console.ReadLine().Split(' ');
            a = int.Parse(abs[0]);
            b = int.Parse(abs[1]);
            c = int.Parse(abs[2]);

            int maiorAB = (a + b + Math.Abs(a - b)) / 2;
            int maiorNumero = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine("{0} eh o maior", maiorNumero);
        }
    }
}