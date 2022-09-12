using ApiChatIdra.Models;
using ApiChatIdra.Repository.Interface;

namespace ApiChatIdra.Repository.Implementation
{
    public class UsuarioSalaRepository : GenericRepository<UsuarioSala>, IUsuarioSalaRepository
    {
        public UsuarioSalaRepository(chatIdraContext db) : base(db)
        {
        }
    }
}
