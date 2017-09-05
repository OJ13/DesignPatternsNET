using System;

namespace _008_DP_Criacao_AbstractFactory
{
    // Produto Concreto
    public class SQLCommand : DBCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Método do Execute de SQLCOmmand foi chamado");
        }
    }
}
