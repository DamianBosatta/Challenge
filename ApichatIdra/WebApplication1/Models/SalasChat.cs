using System;
using System.Collections.Generic;

namespace ApiChatIdra.Models
{
    public partial class SalasChat
    {
        public SalasChat()
        {
            Mensajes = new HashSet<Mensaje>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        /// <summary>
        /// 0 publico\n1 privado
        /// </summary>
        public bool IdTipoSala { get; set; }

        public virtual ICollection<Mensaje> Mensajes { get; set; }
    }
}
