using System;
using System.Collections.Generic;

namespace ApiChatIdra.Models
{
    public partial class Mensaje
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdSala { get; set; }
        public string? Mensaje1 { get; set; }

        public virtual SalasChat IdSalaNavigation { get; set; } = null!;
        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
    }
}
