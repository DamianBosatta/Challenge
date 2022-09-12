using ApiChatIdra.Models;
using ApiChatIdra.Repository.Interface;

namespace ApiChatIdra.Repository.Implementation
{
    public class SalasChatRepository : GenericRepository<SalasChat>, ISalasChatRepository
    {
        public SalasChatRepository(chatIdraContext db) : base(db)
        {
        }
    }
}
