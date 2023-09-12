using AutoMapper;
using NotaAlunoApi.Data.Dto;
using NotaAlunoApi.Data.Dto.UsuarioDto;
using NotaAlunoApi.Model;

namespace NotaAlunoApi.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
            CreateMap<Usuario, ReadUsuarioDto>();
            CreateMap<UpdateUsuarioDto, Usuario>();
        }
    }
}
