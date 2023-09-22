using AutoMapper;
using NotaAlunoApi.Data.Dto.Permissao;
using NotaAlunoApi.Model;

namespace NotaAlunoApi.Profiles
{
    public class PermissaoProfile : Profile
    {
        public PermissaoProfile() 
        {
            CreateMap<CreatePermissaoDto, Permissao>();
            CreateMap<Permissao, ReadPermissaoDto>();
            CreateMap<UpdatePermissaoDto, Permissao>();
        }
    }
}
