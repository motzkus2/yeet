using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Git
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] bla = Forskellige(4, 6);

            foreach (double tal in bla)
            {
                Console.WriteLine(tal);
            }
            Console.WriteLine("YEET");
            Console.WriteLine("Forstill dig vis skipper kom gående ind af døren");
            Thread.Sleep(1000);
            Console.WriteLine("Skipper åbner døren");
            Console.ReadKey();
            Console.WriteLine("uhhh");
        }

        static int Sum(int a, int b)
        {
            int resultat = a + b;

            return resultat;
        }

        static double Divider(int a, int b)
        {
            double resultat = a / b;

            return resultat;
        }

        static double Gange(int a, int b, int c)
        {
            double resultat = a * b * c;

            return resultat;
        }

        static double[] Forskellige(int a, int b)
        {
            double[] alle = { a + b , a - b, a * b, a / b};

            return alle;
        }

        static double Gennemsnit(int a, int b, int c, int d)
        {
            double[] tal = { a, b, c, d };

            return tal.Average();
        }
    }
}
