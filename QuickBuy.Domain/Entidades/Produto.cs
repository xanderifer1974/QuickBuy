namespace QuickBuy.Domain.Entidades
{
    public class Produto: Entidades
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Crítica - Nome não pode estar vazio");

            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("Crítica - Descrição não pode estar vazio.");

            if (Preco <= 0)
                AdicionarCritica("Crítica - Preço não pode ser menor ou igual a zero");
        }
    }
}
