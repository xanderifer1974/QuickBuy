namespace QuickBuy.Domain.Entidades
{
    public  class ItemPedido: Entidades
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (Quantidade == 0 )
            {
                AdicionarCritica("Crítica - Quantidade deve ser maior que zero");
            }
        }
    }
}
