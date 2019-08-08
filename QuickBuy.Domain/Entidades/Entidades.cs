﻿using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entidades
{
    public abstract class Entidades
    {
        private List<string> _mensagensValidacao { get; set; }
        private List<string> mensagemValidacao {

            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }

        }

        protected void LimparMensagemValidacao()
        {

            mensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
           mensagemValidacao.Add(mensagem);
        }

        public abstract void Validate();
        protected bool EhValido
        {
            get { return !mensagemValidacao.Any(); }
        }

    }
}
