using System;

namespace _011_DP_Criacao_Prototype
{
    //Concrete Product
    public class Livro : Item
    {
        public Livro(int id, string descricao, double preco)
               :base(id,descricao,preco)
        {

        }
        //Clonar
        public override Item Clone()
        {
            return (Item)this.MemberwiseClone();  //Cria uma cópia do objeto
        }
    }
}
