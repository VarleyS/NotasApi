namespace NotaAlunoApi.Data.Dto.NotaDto
{
    public class CreateNotaDto
    {
        public int Portugues { get; set; }
        public int Matematica { get; set; }
        public int Historia { get; set; }
        public int Geografia { get; set; }
        public int Ingles { get; set; }
        public int Ciencias { get; set; }
        public int AlunoId { get; set; }
    }
}
