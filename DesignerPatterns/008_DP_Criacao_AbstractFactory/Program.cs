using System;
namespace _008_DP_Criacao_AbstractFactory
{
    //Classe Client
    class Program
    {
        static void Main(string[] args)
        {
            //var con = new SQLConnection();
            //con.Open();
            //var cmd = new SQLCommand();
            //cmd.Execute();

            //USando Abstract Factory
            DB_AbsFactory db = new SQL_ConcFactory();
            //DB_AbsFactory db = new Oracle_ConFactory();
            var con = db.createConnection();
            con.Open();
            var cmd = db.createCommand();
            cmd.Execute();

            Console.ReadKey();
        }
    }
}
