using System;

namespace _002_Heranca
{
    public class Funcionario : Pessoa
    {
        public string Departamento { get; set; }
        public void Trabalhar()
        {
            Console.WriteLine(Nome + " trabalhando");
        }
    }
}
