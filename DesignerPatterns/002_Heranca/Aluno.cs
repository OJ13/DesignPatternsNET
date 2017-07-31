using System;

namespace _002_Heranca
{
    public class Aluno : Pessoa
    {
        public int Matricula { get; set; }

        public void Estudar()
        {
            Console.WriteLine(Nome + " estudando");
        }
    }
}
