﻿using QuickBuy.Domain.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace QuickBuy.Domain.Entidades
{
   public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string  Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um
        /// ou muitos pedidos.
        /// </summary>
        public ICollection <ItemPedido> ItensPedido { get; set; }

    }
}
