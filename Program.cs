using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X");
            double X = double.Parse((Console.ReadLine()));
            Console.WriteLine("Enter Y");
            double Y = double.Parse((Console.ReadLine()));
            Console.WriteLine("Enter Z");
            double Z = double.Parse((Console.ReadLine()));
            double Chislitel, Znamenatel, F;
            Chislitel = Math.Min(X, Y + Z) + Math.Pow(Math.E, X);
            Znamenatel = Math.Max(X * X, Y) + Z * Z * Z;
            if (Znamenatel == 0)
            {
                Console.WriteLine("INCORRECTLY");
            }
            else
            {
                F = (Chislitel / Znamenatel);
                Console.WriteLine(F);
            }
            System.Threading.Thread.Sleep(5000);
        }
    }
}
