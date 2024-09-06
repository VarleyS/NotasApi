using NotaAlunoApi.Data.Dto.NotaDto;

namespace NotaAlunoApi.Data.Dto
{
    public class ReadAlunoDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DataNascimento { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string Responsavel { get; set; }
        public ReadNotaDto ReadNotaDto { get; set; }
    }
}
