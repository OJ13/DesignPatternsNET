using System;

namespace _005_ClasseAbstrata
{
    public class Notebook
    {
        private string _nome;
        public string getNome()
        {
            return _nome;
        }
        public Notebook(string nome)
        {
            _nome = nome;
        }
        public Iphone iPhone { get; set; }
        public Mouse Mouse { get; set; }
        public Teclado Teclado { get; set; }
    }
    public abstract class USB
    {
        public abstract void Plugar();
    }
    public class Iphone : USB
    {
        public override void Plugar()
        {
            throw new NotImplementedException();
        }
    }
    public class Mouse : USB
    {
        public override void Plugar()
        {
            throw new NotImplementedException();
        }
    }
    public class Teclado : USB
    {
        public override void Plugar()
        {
            throw new NotImplementedException();
        }
    }
    public class Tablet : USB
    {
        public override void Plugar()
        {
            throw new NotImplementedException();
        }
    }
}
