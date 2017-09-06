namespace _009_DP_Criacao_Builder
{
    public class Director
    {
        public void Construct(VeiculoBuilder builder)
        {
            builder.BuildMotor();
            builder.BuildPortas();
            builder.BuildPneus();
        }
    }
}
