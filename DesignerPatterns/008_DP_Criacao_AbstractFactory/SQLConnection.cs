using System;

namespace _008_DP_Criacao_AbstractFactory
{
        //Produto Concreto (Concrete Product)
    public class SQLConnection : DBConnection
    {
        public override void Open()
        {
            Console.WriteLine("Método Open do SQLConnection foi chamado");
        }
    }
}
