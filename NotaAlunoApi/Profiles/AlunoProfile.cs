using AutoMapper;
using NotaAlunoApi.Data.Dto;
using NotaAlunoApi.Model;

namespace NotaAlunoApi.Profiles
{
    public class AlunoProfile : Profile
    {
        public AlunoProfile()
        {
            CreateMap<CreateAlunoDto, Aluno>();
            CreateMap<Aluno, ReadAlunoDto>().ForMember(alunoDto => alunoDto.ReadNotaDto, opt => opt.MapFrom(aluno => aluno.Nota));
            CreateMap<UpdateAlunoDto, Aluno>();
        }
    }
}
