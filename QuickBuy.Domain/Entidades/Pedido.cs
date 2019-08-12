﻿using QuickBuy.Domain.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace QuickBuy.Domain.Entidades
{
   public class Pedido: Entidades
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string  Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um item de pedido
        /// ou muitos item de pedidos.
        /// </summary>
        public virtual ICollection <ItemPedido> ItensPedido { get; set; }

        /// <summary>
        /// Método para validar a classe
        /// </summary>
        public override void Validate()
        {
           LimparMensagemValidacao();
            if (!ItensPedido.Any())
                AdicionarCritica("Crítica - Pedido não pode ficar sem ítem de pedido");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Crítica - CEP deve estar preenchido");
               
        }
    }
}
