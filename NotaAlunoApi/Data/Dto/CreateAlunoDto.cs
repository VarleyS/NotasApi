namespace NotaAlunoApi.Data.Dto
{
    public class CreateAlunoDto
    {
        public string Name { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string Responsavel { get; set; }
    }
}
