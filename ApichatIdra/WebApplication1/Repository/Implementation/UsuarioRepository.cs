using ApiChatIdra.Models;
using ApiChatIdra.Repository.Interface;

namespace ApiChatIdra.Repository.Implementation
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(chatIdraContext db) : base(db)
        {
        }
        public Usuario GetByEmail(string nombre)
        {
            return _db.Usuarios.FirstOrDefault(a => a.Nombre == nombre);
        }
        public bool ExisteUsuario(string nombre)
        {
            return _db.Usuarios.Any(a => a.Nombre == nombre);
        }
    }
}
