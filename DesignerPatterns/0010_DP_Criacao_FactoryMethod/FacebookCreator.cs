namespace _0010_DP_Criacao_FactoryMethod
{
    // Concrete Creator
    public class FacebookCreator : Creator
    {
        public override Autenticacao CreateInstance()
        {
            return new AutenticacaoFacebook();
        }
    }
}
