using System;
namespace _011_DP_Criacao_Prototype
{
    class Program
    {
        //Client
        static void Main(string[] args)
        {
            //Cria um objeto protótipo e um clone
            Livro p1 = new Livro(1, "Design Patterns", 800.00);
            Livro c1 = (Livro)p1.Clone();
            Console.WriteLine("Protótipo: " + p1.Descricao);
            Console.WriteLine("Clone: " + c1.Descricao);

            //Cria um objeto protótipo e um clone
            DVD p2 = new DVD(2, "Programcao OO", 80.00);
            DVD c2 = (DVD)p2.Clone();
            Console.WriteLine("Protótipo: " + p2.Descricao);
            Console.WriteLine("Clone: " + c2.Descricao);

            Console.ReadKey();

        }
    }
}
