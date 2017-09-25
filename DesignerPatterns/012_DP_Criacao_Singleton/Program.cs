using System;

namespace _012_DP_Criacao_Singleton
{
    // Client
    class Program
    {
        static void Main(string[] args)
        {
            var con = ConexaoBD.Instance();
            con.stringConexao = "Sql Server";
            con.Open();
            var con2 = ConexaoBD.Instance();
            //Comprovando que são a mesma instância
            if(con == con2) //esta referenciando a mesma posição de memória, apontando para o mesmo objeto
            {
                Console.WriteLine("Conexao são iguais");
            }
            con.Open();

            Console.ReadKey();
        }
    }
}
