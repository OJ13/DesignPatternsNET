using System;

namespace _005_ClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook acer = new Notebook("Acer");

            acer.iPhone = new Iphone();
            acer.Teclado = new Teclado();

            Console.ReadKey();
        }
    }
}
