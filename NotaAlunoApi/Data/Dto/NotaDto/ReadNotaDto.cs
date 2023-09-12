namespace NotaAlunoApi.Data.Dto.NotaDto
{
    public class ReadNotaDto
    {
        public int NotaId { get; set; }
        public int Portugues { get; set; }
        public int Matematica { get; set; }
        public int Historia { get; set; }
        public int Geografia { get; set; }
        public int Ingles { get; set; }
        public int Ciencias { get; set; }
        public int AlunoId { get; set; }
    }
}
