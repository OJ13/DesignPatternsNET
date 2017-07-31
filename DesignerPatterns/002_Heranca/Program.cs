using System;

namespace _002_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno al1 = new Aluno();
            al1.Matricula = 123;
            al1.Nome = "Rocky";
            al1.Estudar();

            Funcionario func = new Funcionario();
            func.Nome = "Apolo";
            func.Departamento = "Dev";
            func.Trabalhar();

            Console.ReadKey();
        }
    }
}
