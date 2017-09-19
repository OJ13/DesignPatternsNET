using System;

namespace _011_DP_Criacao_Prototype
{
    // Concrete Prototype
    public class DVD : Item
    {
        public DVD(int id, string descricao, double preco) 
            :base(id,descricao,preco)
        {}

        //Clonar
        public override Item Clone()
        {
            return (Item)MemberwiseClone();
        }
    }
}
