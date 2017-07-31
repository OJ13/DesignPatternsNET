using System;

namespace _001_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            //in Code
            
            //int r = x + y;
            
            //Por método
            //int r = Somar(x, y);

            //Por classe
            Calc c = new Calc();
            int r = c.Somar(x, y);

            Console.WriteLine("A soma de {0} com {1} é {2}", x, y, r);
            Console.ReadKey();

            //private static int Somar(int a, int b)
            //{
            //    return a + b;
            //}
        }
    }
}
