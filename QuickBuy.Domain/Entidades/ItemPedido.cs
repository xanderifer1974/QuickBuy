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
            if (ProdutoId == 0)
                AdicionarCritica("Crítica - Não foi identificada a referência do produto");

            if (Quantidade == 0 )
            {
                AdicionarCritica("Crítica - Quantidade deve ser maior que zero");
            }
        }
    }
}
