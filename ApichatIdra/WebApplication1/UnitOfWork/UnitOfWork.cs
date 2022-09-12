using ApiChatIdra.Models;
using ApiChatIdra.Repository.Implementation;
using ApiChatIdra.Repository.Interface;

namespace ApiChatIdra.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly chatIdraContext _context;

        public IUsuarioRepository UsuarioRepo { get; private set; }

        public IMensajeRepository MensajeRepo { get; private set; }

        public ISalasChatRepository SalasChatRepo { get; private set; }

        public IUsuarioSalaRepository UsuarioSalaRepo { get; private set; }

        public UnitOfWork(chatIdraContext context)
        {
            UsuarioRepo = new UsuarioRepository(context);
            MensajeRepo = new MensajeRepository(context);
            SalasChatRepo = new SalasChatRepository(context);
            UsuarioSalaRepo = new UsuarioSalaRepository(context);
            _context = context;
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
