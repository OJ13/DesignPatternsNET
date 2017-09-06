using System;

namespace _009_DP_Criacao_Builder
{
    public class MotoBuilder : VeiculoBuilder
    {
        public MotoBuilder()
        {
            _veiculo = new Veiculo("Motocicleta");
        }
        public override void BuildMotor()
        {
            _veiculo["motor"] = "50cv";
        }

        public override void BuildPneus()
        {
            _veiculo["pneus"] = "2";
        }

        public override void BuildPortas()
        {
            _veiculo["portas"] = "N/D";
        }
    }
}
