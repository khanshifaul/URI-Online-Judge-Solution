/*  URI_1011
   Make a program that calculates and shows the volume of a sphere being provided the value of its radius (R) . 
   The formula to calculate the volume is: (4/3) * pi * R3. Consider (assign) for pi the value 3.14159.

   Tip: Use (4/3.0) or (4.0/3) in your formula, because some languages (including C++) assume that the division's result between two integers is another integer. :)

   3

   VOLUME = 113.097
 */
using System;

namespace URI1011
{
    internal static class URI
    {
        private static void Main(string[] args)
        {
            int R;
            double VOLUME;
            const double PI = 3.14159;

            R = Convert.ToInt32(Console.ReadLine());

            VOLUME = (4.0 / 3) * PI * R * R * R;

            Console.WriteLine("VOLUME = {0:F3}", VOLUME);
        }
    }
}