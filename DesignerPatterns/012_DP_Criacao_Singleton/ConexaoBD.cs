using System;

namespace _012_DP_Criacao_Singleton
{
    public class ConexaoBD
    {
        // Singleton

        //Criar ponto de entrada único
        //guarda internamente a instância
        private static ConexaoBD _instance;

        //Esconde o construtor
        protected ConexaoBD()
        {

        }
        //Método que retorna o singleton
        public static ConexaoBD Instance()
        {
            // Vai garantir que sempre uma instância exista, só uma
            if(_instance == null)
            {
                _instance = new ConexaoBD();
            }
            return _instance;
        }
        public string stringConexao { get; set; }

        public void Open()
        {
            Console.WriteLine("Abrindo conexao com o banco - " + stringConexao);
        }
    }
}
