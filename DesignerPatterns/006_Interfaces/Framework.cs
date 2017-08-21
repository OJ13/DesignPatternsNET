using System;

namespace _006_Interfaces
{
    public interface IEditar
    {
        void Editar();
    }
    public interface IImprimir
    {
        void Imprimir();
    }
    public abstract class Arquivo
    {
        private int _tamArquivo { get; set; }
        public int TamArquivo
        {
            get { return _tamArquivo; }
            set { _tamArquivo = value; }
        }
        private string _descricao { get; set; }
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        public virtual void Abrir()
        {
            Console.WriteLine("Abrindo arquivo " + _descricao + " ...");
        }

    }
    public class MP3 : Arquivo
    {
        public override void Abrir()
        {
            Console.WriteLine("Tocando arquivo " + Descricao + " ...");
        }
    }
    public class Foto : Arquivo, IImprimir, IEditar
    {
        public override void Abrir()
        {
            Console.WriteLine("Mostrando imagem " + Descricao + " ...");
        }
        public void Editar()
        {
            //Implementar
            Console.WriteLine("Editando Foto");
        }
        public void Imprimir()
        {
            //Implementar
            Console.WriteLine("Imprimindo Foto");
        }
    }
    public class Documento : Arquivo, IEditar, IImprimir
    {
        public override void Abrir()
        {
            Console.WriteLine("Exibindo arquivo " + Descricao + " ...");
        }

        public void Editar()
        {
            Console.WriteLine("Editando Documento");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimindo Documento");
        }
    }
}
