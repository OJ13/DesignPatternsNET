using System;

namespace _008_DP_Criacao_AbstractFactory
{
    public class Oracle_ConFactory : DB_AbsFactory
    {
        public override DBCommand createCommand()
        {
            return new OracleCommand();
        }

        public override DBConnection createConnection()
        {
            return new OracleConnection();
        }
    }
}
