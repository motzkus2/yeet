using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regnvejr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast måleværdierne for de sidste 7 dage:");

            Console.WriteLine("Mandag:");
            double mandag = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Tirsdag:");
            double tirsdag = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Onsdag:");
            double onsdag = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Torsdag:");
            double torsdag = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Fredag:");
            double fredag = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Lørdag:");
            double lørdag = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Søndag:");
            double søndag = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            double[] måleværdier = new double[] { mandag, tirsdag, onsdag, torsdag, fredag, lørdag, søndag };

            Console.WriteLine("Vælg hvilken metode du vil bruge:");

            Console.WriteLine("1: Gennemsnittet");
            Console.WriteLine("2: Maksimum-værdien");
            Console.WriteLine("3: Minimum-værdien");

            int valg = Convert.ToInt32(Console.ReadLine());

            switch (valg)
            {
                case 1:
                    Console.WriteLine("Gennesmittet er: {0}", Gennemsnit(måleværdier));
                    break;

                case 2:
                    Console.WriteLine("Maksimum er: {0}", Maksimum(måleværdier));
                    break;

                case 3:
                    Console.WriteLine("Minimum er: {0}", Minimum(måleværdier));
                    break;

                default:
                    break;
            }

            Console.ReadLine();


        }

        static public double Gennemsnit(double[] måleværdier)
        {
            double gennemsnit = måleværdier.Average();

            return gennemsnit;
        }

        static public double Maksimum(double[] måleværdier)
        {
            double maksimum = måleværdier.Max();

            return maksimum;
        }

        static public double Minimum(double[] måleværdier)
        {
            double minimum = måleværdier.Min();

            return minimum;
        }




    }
}
