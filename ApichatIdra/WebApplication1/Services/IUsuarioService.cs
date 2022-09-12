using ApiChatIdra.Request;
using ApiChatIdra.Response;

namespace ApiChatIdra.Services
{
    public interface IUsuarioService
    {
        UsuarioResponse Register(UsuarioRequest user);

    }
}
