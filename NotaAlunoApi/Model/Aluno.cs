using NotaAlunoApi.Utils;
using System.Numerics;

namespace NotaAlunoApi.Model
{
    public class Aluno
    {
        public Aluno() { }


        public Aluno(string name, string dataNascimento, string cpf, string rg, string sexo, string telefone)
        {
            Validation(name, dataNascimento, cpf, rg, sexo, telefone);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string DataNascimento { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public virtual Nota Nota { get; set; }

        private void Validation(string name, string dataNascimento, string cpf, string rg, string sexo, string telefone)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (dataNascimento != null)
            {
                var verificador = ValidaDataAni.ValidaData(dataNascimento);
                if (verificador == false)
                {
                    throw new InvalidOperationException("Data inválida!");
                }
            }
            if (cpf != null)
            {
                var verificador = ValidaCpf.IsValidaCpf(cpf);
                if (verificador == false)
                {
                    throw new InvalidOperationException("Cpf inválido!");
                }
            }
            if (rg == null)
            {
                throw new ArgumentNullException("rg");
            }
            if (sexo == null)
            {
                throw new ArgumentNullException("sexo");
            }
            if (telefone != null)
            {
                var validador = ValidaTelefone.ValidaTel(telefone);
                if (validador == false)
                {
                    throw new ArgumentNullException("telefone");
                }
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
