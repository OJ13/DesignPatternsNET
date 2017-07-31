using System;

namespace _003_Polimorfismo
{
    public class Aviao : MeioTransporte
    {
        //public string Modelo { get; set; }

        public override void Mover()
        {
            Console.WriteLine(Modelo + " voando...");
        }
    }
}
