using ApiChatIdra.Models;
using ApiChatIdra.Request;
using ApiChatIdra.Response;
using ApiChatIdra.UnitOfWork;
using AutoMapper;

namespace ApiChatIdra.Services
{
    public class UsuarioService :IUsuarioService
    {
        private readonly IUnitOfWork _uOW;

        private readonly IMapper _mapper;

        public UsuarioService(IUnitOfWork uow, IMapper mapper)
        {
            _uOW = uow;

            _mapper = mapper;
        }



        public UsuarioResponse Register(UsuarioRequest user)
        {
            Usuario usuario = _mapper.Map<Usuario>(user);

            _uOW.UsuarioRepo.Insert(usuario);
            _uOW.Save();
            UsuarioResponse response = _mapper.Map<UsuarioResponse>(usuario);
            return response;
        }

     
    }
}
