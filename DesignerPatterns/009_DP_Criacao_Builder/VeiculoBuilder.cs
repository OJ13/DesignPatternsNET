namespace _009_DP_Criacao_Builder
{
    //Builder
    public abstract class VeiculoBuilder
    {
        protected Veiculo _veiculo;
        public Veiculo veiculo
        {
            get { return _veiculo; }
        }

        //processo de construção (abstrato)
        public abstract void BuildMotor();
        public abstract void BuildPortas();
        public abstract void BuildPneus();
    }
}
