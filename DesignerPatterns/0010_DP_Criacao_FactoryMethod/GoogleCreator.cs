using System;

namespace _0010_DP_Criacao_FactoryMethod
{
    // Concrete Creator
    public class GoogleCreator : Creator
    {
        public override Autenticacao CreateInstance()
        {
            return new AutenticacaoGoogle();
        }
    }
}
