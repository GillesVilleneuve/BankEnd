using Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
  public  class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        public ICollection<ItemPedido> ItensPedido { get; set; } // Lista de Itens



    }
}
