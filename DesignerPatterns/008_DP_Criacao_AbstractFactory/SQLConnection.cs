using System;

namespace _008_DP_Criacao_AbstractFactory
{
    public class SQLConnection : DBConnection
    {
        public override void Open()
        {
            throw new NotImplementedException();
        }
    }
}
