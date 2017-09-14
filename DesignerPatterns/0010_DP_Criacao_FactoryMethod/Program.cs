using System;

namespace _0010_DP_Criacao_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //var login = new AutenticacaoGoogle();
            //login.Autenticar();

            Creator[] creators = new Creator[2];

            creators[0] = new FacebookCreator();
            creators[1] = new GoogleCreator();

            foreach (Creator c in creators)
            {
                Autenticacao aut = c.CreateInstance(); //Factory Method
                aut.Autenticar();
            }

            Console.ReadKey();
        }
    }
}
