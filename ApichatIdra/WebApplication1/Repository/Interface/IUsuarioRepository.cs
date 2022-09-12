using ApiChatIdra.Models;

namespace ApiChatIdra.Repository.Interface
{
   
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {
        Usuario GetByEmail(string email);
        bool ExisteUsuario(string email);
    }
}
