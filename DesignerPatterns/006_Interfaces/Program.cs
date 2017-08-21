using System;
namespace _006_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Arquivo doc = new Documento() { Descricao = "Artigo .NET Magazine" };
            MP3 musica = new MP3() { Descricao = "I Believe I can Fly" };
            Foto foto = new Foto() { Descricao = "Palestra .NET" };

            doc.Abrir();
            musica.Abrir();
            foto.Abrir();
            foto.Imprimir();

            Console.ReadKey();
        }
    }
}
