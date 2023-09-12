using AutoMapper;
using NotaAlunoApi.Data.Dto.NotaDto;
using NotaAlunoApi.Model;

namespace NotaAlunoApi.Profiles
{
    public class NotaProfile : Profile
    {
        public NotaProfile()
        {
            CreateMap<CreateNotaDto, Nota>();
            CreateMap<Nota, ReadNotaDto>();
            CreateMap<UpdateNotaDto, Nota>();
        }
    }
}
