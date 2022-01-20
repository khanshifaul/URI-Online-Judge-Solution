using System;
namespace URI1005
{
    internal static class URI
    {
        private static void Main(string[] args)
        {
            /* Read two floating points' values of double precision A and B, corresponding to two student's grades. 
            After this, calculate the student's average, considering that grade A has weight 3.5 and B has weight 7.5. 
            Each grade can be from zero to ten, always with one digit after the decimal point. 
            Don’t forget to print the end of line after the result, otherwise you will receive “Presentation Error”. 
            Don’t forget the space before and after the equal sign. */
            double A, B, MEDIA;

            A = Convert.ToDouble(Console.ReadLine(), null);
            B = Convert.ToDouble(Console.ReadLine(), null);

            MEDIA = (3.5 * A + 7.5 * B) / (3.5 + 7.5);

            Console.WriteLine("MEDIA = {0:F5}", MEDIA);
        }
    }
}