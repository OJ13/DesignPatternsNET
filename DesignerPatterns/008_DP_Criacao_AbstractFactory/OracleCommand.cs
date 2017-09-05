using System;

namespace _008_DP_Criacao_AbstractFactory
{
    //Produto Concreto
    public class OracleCommand : DBCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Método Execute do OracleCOmmand foi chamado");
        }
    }
}
