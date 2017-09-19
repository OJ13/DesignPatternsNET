namespace _011_DP_Criacao_Prototype
{
    // Prototype
    public abstract class Item
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Item(int id, string desc, double preco)
        {
            this.Id = id;
            this.Descricao = desc;
            this.Preco = preco;
        }

        //clonar
        public abstract Item Clone();
    }
}
