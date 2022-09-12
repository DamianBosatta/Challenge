using ApiChatIdra.Models;
using ApiChatIdra.Repository.Interface;

namespace ApiChatIdra.Repository.Implementation
{
    public class MensajeRepository : GenericRepository<Mensaje>, IMensajeRepository
    {
        public MensajeRepository(chatIdraContext db) : base(db)
        {
        }
    }
}
