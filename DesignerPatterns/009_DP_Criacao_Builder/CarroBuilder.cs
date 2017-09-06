using System;

namespace _009_DP_Criacao_Builder
{
    //Concrete Builder
    public class CarroBuilder : VeiculoBuilder
    {
        public CarroBuilder()
        {
            _veiculo = new Veiculo("Carro Passeio");
        }
        public override void BuildMotor()
        {
            _veiculo["motor"] = "127cv";
        }

        public override void BuildPneus()
        {
            _veiculo["pneus"] = "4";
        }

        public override void BuildPortas()
        {
            _veiculo["portas"] = "5p";
        }
    }
}
