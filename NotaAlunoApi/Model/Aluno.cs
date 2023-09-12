namespace NotaAlunoApi.Model
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Nota Nota { get; set; }

    }
}
