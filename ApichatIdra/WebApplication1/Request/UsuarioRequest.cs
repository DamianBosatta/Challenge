using System.ComponentModel.DataAnnotations;

namespace ApiChatIdra.Request
{
    public class UsuarioRequest
    {
        public int Id { get; set; }
        public string? Nombre { get; set; } 
        public int Edad { get; set; }
        public string? Usuario1 { get; set; } 
        public string? Password { get; set; } 
    }
}
