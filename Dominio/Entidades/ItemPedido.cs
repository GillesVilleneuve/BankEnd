﻿namespace Dominio.Entidades
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public int ProdutoId { get; set; } // referencia do produto

    }
}
