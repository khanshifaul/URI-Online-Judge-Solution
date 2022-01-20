namespace URI1019
{
    internal static class URI
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int h = 0;
            int m = 0;
            int s = 0;

            if (N >= 3600)
            {
                h = N / 3600;
                N -= h * 3600;
            }
            if (N >= 60)
            {
                m = N / 60;
                N -= m * 60;
            }
            if (N < 60)
            {
                s = N;
            }
            Console.WriteLine($"{h}:{m}:{s}");
        }
    }
}
