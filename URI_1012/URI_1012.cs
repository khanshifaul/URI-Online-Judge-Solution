/* URI_1012
      Make a program that reads three floating point values: A, B and C. Then, calculate and show:
      a) the area of the rectangled triangle that has base A and height C.
      b) the area of the radius's circle C. (pi = 3.14159)
      c) the area of the trapezium which has A and B by base, and C by height.
      d) the area of the square that has side B.
      e) the area of the rectangle that has sides A and B.

      3.0 4.0 5.2

      TRIANGULO: 7.800
      CIRCULO: 84.949
      TRAPEZIO: 18.200
      QUADRADO: 16.000
      RETANGULO: 12.000
    */
namespace URI1012
{
    internal static class URI
    {
        private static void Main(string[] args)
        {
            double A, B, C, TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO;
            const double PI = 3.14159;

            string[] ABC = Console.ReadLine().Split(' ');

            A = double.Parse(ABC[0]);
            B = double.Parse(ABC[1]);
            C = double.Parse(ABC[2]);

            TRIANGULO = A * C / 2.0;
            CIRCULO = PI * C * C;
            TRAPEZIO = (A + B) * C / 2.0;
            QUADRADO = B * B;
            RETANGULO = A * B;

            Console.WriteLine("TRIANGULO: {0:F3}", TRIANGULO);
            Console.WriteLine("CIRCULO: {0:F3}", CIRCULO);
            Console.WriteLine("TRAPEZIO: {0:F3}", TRAPEZIO);
            Console.WriteLine("QUADRADO: {0:F3}", QUADRADO);
            Console.WriteLine("RETANGULO: {0:F3}", RETANGULO);
        }
    }
}