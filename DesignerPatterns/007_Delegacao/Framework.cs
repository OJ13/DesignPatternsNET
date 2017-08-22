using System;

namespace _007_Delegacao
{
    public class Funcionario
    {
        public void Trabalhar(string tarefa)
        {
            Console.WriteLine("Funcionário Trabalhando...");
        }
    }
    public class Estagiario
    {
        public void Trabalhar(string tarefa)
        {
            Console.WriteLine("Funcionário Trabalhando...");
        }
    }

    public class Developer : Funcionario
    {
        public void Trabalhar(string tarefa)
        {
            Console.WriteLine("Developer Programando...");
        }
    }
    public class ArquitetoSoftware : Funcionario
    {
        public void Trabalhar(string tarefa)
        {
            Console.WriteLine("Arquiteto Projetando...");
        }
    }

    public class Gerente
    {
        private Estagiario _estagiario;
        private Developer _developer;
        private ArquitetoSoftware _arquiteto;

        public Gerente()
        {
            _estagiario = new Estagiario();
            _developer = new Developer();
            _arquiteto = new ArquitetoSoftware();
        }
        public void Trabalhar(string tarefa)
        {
            Console.WriteLine("Gerente recebeu a tarefa " + tarefa);
            //Implementando uma tarefa por delegação
            _estagiario.Trabalhar(tarefa);
            _developer.Trabalhar(tarefa);
            _arquiteto.Trabalhar(tarefa);
        }
    }
}
