using NotaAlunoApi.Utils;
using System.Numerics;

namespace NotaAlunoApi.Model
{
    public class Aluno
    {
        public Aluno() { }

        public Aluno(string name, DateTime dataNascimento, string cpf, string rg, string sexo, string telefone)
        {
            Validation(name, dataNascimento, cpf, rg, sexo, telefone);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public virtual Nota Nota { get; set; }

        private void Validation(string name, DateTime dataNascimento, string cpf, string rg, string sexo, string telefone)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (dataNascimento == null)
            {
                throw new ArgumentNullException("dataNascimento");
            }
            if (cpf != null)
            {
                Utils.ValidaCpf.IsValidaCpf(cpf);
            }
            if (rg == null)
            {
                throw new ArgumentNullException("rg");
            }
            if (sexo == null)
            {
                throw new ArgumentNullException("sexo");
            }
            if (telefone == null)
            {
                throw new ArgumentNullException("telefone");
            }

            Name = name;
            DataNascimento = dataNascimento;
            CPF = cpf;
            RG = rg;
            Sexo = sexo;
            Telefone = telefone;
        }
    }
}
