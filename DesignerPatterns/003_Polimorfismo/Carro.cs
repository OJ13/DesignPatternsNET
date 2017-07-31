using System;

namespace _003_Polimorfismo
{
    public class Carro : MeioTransporte
    {
        public string Marca { get; set; }
        //public string Modelo { get; set; }
        public override void Mover()
        {
            Console.WriteLine(Marca + " " + Modelo + " andando...");
        }
    }
}
