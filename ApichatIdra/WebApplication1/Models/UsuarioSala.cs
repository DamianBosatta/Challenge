using System;
using System.Collections.Generic;

namespace ApiChatIdra.Models
{
    public partial class UsuarioSala
    {
        public int? IdUsuario { get; set; }
        public int? IdSala { get; set; }

        public virtual SalasChat? IdSalaNavigation { get; set; }
        public virtual Usuario? IdUsuarioNavigation { get; set; }
    }
}
