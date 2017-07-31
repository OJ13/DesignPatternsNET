using System;

namespace _004_Encapsulamento
{
    class Program
    {
        //usuário - Client
        static void Main(string[] args)
        {
            Carro Astra = new Carro();
            Astra.Abastecer();
            Astra.Ligar();
            Astra.Mover();

            Console.ReadKey();
        }
    }
}
