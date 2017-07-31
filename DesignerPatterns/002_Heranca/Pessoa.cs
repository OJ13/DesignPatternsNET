using System;

namespace _002_Heranca
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public void Dormir()
        {
            Console.WriteLine(Nome + " dormindo");
        }
    }
}
