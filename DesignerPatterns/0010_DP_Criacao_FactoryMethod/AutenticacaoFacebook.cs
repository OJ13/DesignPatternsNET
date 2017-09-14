using System;
namespace _0010_DP_Criacao_FactoryMethod
{
    //Produto Concreto
    public class AutenticacaoFacebook : Autenticacao
    {
        public override void Autenticar()
        {
            Console.WriteLine("Autenticando via Facebook");
        }
    }
}
