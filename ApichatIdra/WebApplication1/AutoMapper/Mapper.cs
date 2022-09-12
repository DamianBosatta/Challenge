using ApiChatIdra.Models;
using ApiChatIdra.Request;
using AutoMapper;

namespace ApiChatIdra.AutoMapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<UsuarioRequest, Usuario>().ReverseMap();
        
            //    .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Name));
            //CreateMap<Personaje, PersonajeResponse>();
            //CreateMap<Pelicula, PeliculaResponse>();
        }
    }
}
