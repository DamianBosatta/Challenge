using ApiChatIdra.Repository.Interface;

namespace ApiChatIdra.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUsuarioRepository UsuarioRepo { get; }
        IMensajeRepository MensajeRepo { get; }
        ISalasChatRepository SalasChatRepo { get; }
        IUsuarioSalaRepository UsuarioSalaRepo { get; }
        void Save();
    }
}
