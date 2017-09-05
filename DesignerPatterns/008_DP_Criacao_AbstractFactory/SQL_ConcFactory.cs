namespace _008_DP_Criacao_AbstractFactory
{
    //Fábrica Concrete (Concrete Factory)
    public class SQL_ConcFactory : DB_AbsFactory
    {
        public override DBConnection createConnection()
        {
            return new SQLConnection();
        }

        public override DBCommand createCommand()
        {
            return new SQLCommand();

        }
    }
}
