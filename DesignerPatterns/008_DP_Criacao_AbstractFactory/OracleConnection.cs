using System;

namespace _008_DP_Criacao_AbstractFactory
{
    // Produto Concreto
    public class OracleConnection : DBConnection
    {
        public override void Open()
        {
            Console.WriteLine("Método Open de OracleCOnnection foi chamado");
        }
    }
}
