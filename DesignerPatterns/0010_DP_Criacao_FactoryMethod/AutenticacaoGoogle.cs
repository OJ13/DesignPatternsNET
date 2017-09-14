using System;
namespace _0010_DP_Criacao_FactoryMethod
{
    public class AutenticacaoGoogle : Autenticacao
    {
        // Product Concrete
        public override void Autenticar()
        {
            Console.WriteLine("Autenticação via Google");
        }
    }
}
