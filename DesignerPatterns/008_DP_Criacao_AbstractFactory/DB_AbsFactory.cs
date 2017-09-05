namespace _008_DP_Criacao_AbstractFactory
{
    //Fábrica Abstrata (Abstract Factory)
    public abstract class DB_AbsFactory
    {
        public abstract DBConnection createConnection();
        public abstract DBCommand createCommand();
    }
}
