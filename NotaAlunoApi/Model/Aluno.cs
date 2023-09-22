namespace NotaAlunoApi.Model
{
    public class Aluno
    {
        public Aluno(string name)
        {
            Validation(name);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Nota Nota { get; set; }

        private void Validation(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            Name = name;
        }
    }
}
