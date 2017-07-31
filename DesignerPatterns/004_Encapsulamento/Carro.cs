using System;

namespace _004_Encapsulamento
{
    public class Bateria
    {

    }
    public class Motor
    {

    }
    public class Carro
    {
        //Encapsulando componentes do carro
        //Composição
        private Motor _motor;
        private Bateria _bateria;
        private string _nome;

        public string Nome
        {
            get
            {
                return _nome;
            }
        }
        public Carro(string nome)
        {
            Console.WriteLine("Criando o objeto carro..");
            _motor = new Motor();
            _bateria = new Bateria();
        }
        public int NumPneus ()
        {
            return 4;
        }

        public void Abastecer()
        {
            Console.WriteLine("Abastecendo o carro...");
        }
        public void Ligar()
        {
            Console.WriteLine("Ligando o carro...");
        }
        public void Mover()
        {
            Console.WriteLine("Movendo o carro...");
        }
    }
}
