using System;

namespace _003_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Carro c = new Carro();
            //c.Marca = "GM";
            //c.Modelo = "Astra";
            //c.Mover();

            //Aviao a = new Aviao();
            //a.Modelo = "F22";
            //a.Mover();

            //(c as Carro).Mover() --TypeCast

            MeioTransporte c = new Carro();
            c.Modelo = "Astra";
            c.Mover();

            MeioTransporte a = new Aviao();
            a.Modelo = "F22";
            a.Mover();


            Console.ReadKey();
        }
    }
}
