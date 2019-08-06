
using System.Collections.Generic;

namespace QuickBuy.Domain.Entidades
{
    public class Usuario: Entidades
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        /// <summary>
        /// Usuário pode ter nenhum ou muitos pedidos
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Crítica - Favor informar o e-mail");

            if (string.IsNullOrEmpty("Crítica - Favor informar uma senha"));

            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Critica - Nome não pode estar em branco");

            if (string.IsNullOrEmpty(SobreNome))
                AdicionarCritica("Crítica - Sobrenome não pode estar em branco");
        }
    }
}
