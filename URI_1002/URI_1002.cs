using System;
namespace URI1002
{
    internal static class URI
    {
        private static void Main(string[] args)
        {
            double A, R;
            const double PI = 3.14159;

            R = Convert.ToDouble(Console.ReadLine());
            A = PI * R * R;

            Console.WriteLine("A={0:F4}", A);
        }
    }
}
