using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public ICollection<Pedido> Pedidos { get; set; } //Lista de Pedidos



    }
}
