using System.Numerics;

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
        public string DataNascimento { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
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
