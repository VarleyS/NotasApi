using NotaAlunoApi.Data.Dto.NotaDto;

namespace NotaAlunoApi.Data.Dto
{
    public class ReadAlunoDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ReadNotaDto ReadNotaDto { get; set; }
    }
}
