using System;

namespace _009_DP_Criacao_Builder
{
    class Program
    {
        //Client
        static void Main(string[] args)
        {
            //Cria Prooduto
            //var carro = new Veiculo("Carro Passeio");
            //carro["motor"] = "127cv";
            //carro["portas"] = "5p";
            //carro["pneus"] = "4";
            //carro.Mostrar();

            //Cria Produto
            //var moto = new Veiculo("Motocicleta");
            //moto["motor"] = "50cv";
            //moto["portas"] = "N/D";
            //moto["pneus"] = "2";
            //moto.Mostrar();

            VeiculoBuilder builder;
            var director = new Director();
            builder = new CarroBuilder();

            director.Construct(builder);
            builder.veiculo.Mostrar();

            VeiculoBuilder builder2;
            var director2 = new Director();
            builder2 = new MotoBuilder();

            director2.Construct(builder2);
            builder2.veiculo.Mostrar();


            Console.ReadKey();
        }
    }
}
