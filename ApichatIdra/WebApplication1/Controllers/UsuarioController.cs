using ApiChatIdra.Models;
using ApiChatIdra.Request;
using ApiChatIdra.Response;
using ApiChatIdra.Services;
using ApiChatIdra.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiChatIdra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly UsuarioService _usuarioService;


        public UsuarioController(IUnitOfWork uow, UsuarioService serUsua)
        {
            _uow = uow;
            _usuarioService = serUsua;
        }


        [HttpPost]
        public async Task<ActionResult> RegistrarUsuario([FromBody] UsuarioRequest user)
        {
            if (_uow.UsuarioRepo.ExisteUsuario(user.Usuario1.ToLower()))
            {
                return BadRequest("Ya existe un cuenta asociada a ese Email");
            }
            UsuarioResponse res = _usuarioService.Register(user);
           
            return Ok(res);
        }



    }
}