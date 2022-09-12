using System;
using System.Collections.Generic;

namespace ApiChatIdra.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Mensajes = new HashSet<Mensaje>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int Edad { get; set; }
        public string Usuario1 { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<Mensaje> Mensajes { get; set; }
    }
}
