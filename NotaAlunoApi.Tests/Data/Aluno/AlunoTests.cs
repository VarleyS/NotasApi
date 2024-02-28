using NotaAlunoApi.Data;
using NotaAlunoApi.Data.Dto;
using NotaAlunoApi.Model;

namespace NotaAlunoApi.Tests.Data.Aluno
{
    public class AlunoTests
    {
        private AlunoContext _context;

        [Fact]
        public void Create_Aluno_Correto()
        {
            var aluno = new Model.Aluno()
            {
                Name = "Varley",
                DataNascimento = "11/22/3333",
                CPF = "111.222.333-44",
                RG = "11.222.333",
                Sexo = "Masculino",
                Telefone = "(00)12345-6789"
            };

            Assert.Equal("Varley", aluno.Name);
            Assert.Equal("11/22/3333", aluno.DataNascimento);
            Assert.Equal("111.222.333-44", aluno.CPF);
            Assert.Equal("11.222.333", aluno.RG);
            Assert.Equal("Masculino", aluno.Sexo);
            Assert.Equal("(00)12345-6789", aluno.Telefone);
        }

        [Fact]
        public void Create_Aluno_Incorreto()
        {
            var aluno = new Model.Aluno()
            {
                Name = "",
                DataNascimento = "",
                CPF = "",
                RG = "",
                Sexo = "",
                Telefone = ""
            };

            Assert.Equal("", aluno.Name);
            Assert.Equal("", aluno.DataNascimento);
            Assert.Equal("", aluno.CPF);
            Assert.Equal("", aluno.RG);
            Assert.Equal("", aluno.Sexo);
            Assert.Equal("", aluno.Telefone);
        }

        [Fact]
        public void Nome_nao_nulo()
        {
            var aluno = new Model.Aluno()
            {
                Name = "",
                DataNascimento = "11/22/3333",
                CPF = "111.222.333-44",
                RG = "11.222.333",
                Sexo = "Masculino",
                Telefone = "(00)12345-6789"
            };

            if (aluno.Name == null)
            {
                Assert.Equal("", aluno.Name);
            }
            Assert.Equal("11/22/3333", aluno.DataNascimento);
            Assert.Equal("111.222.333-44", aluno.CPF);
            Assert.Equal("11.222.333", aluno.RG);
            Assert.Equal("Masculino", aluno.Sexo);
            Assert.Equal("(00)12345-6789", aluno.Telefone);
        }

        [Fact]
        public void DataNascimento_nao_nulo()
        {
            var aluno = new Model.Aluno()
            {
                Name = "Varley",
                DataNascimento = "",
                CPF = "111.222.333-44",
                RG = "11.222.333",
                Sexo = "Masculino",
                Telefone = "(00)12345-6789"
            };

            Assert.Equal("Varley", aluno.Name);

            if (aluno.DataNascimento == null)
            {
                Assert.Equal("", aluno.DataNascimento);
            }

            Assert.Equal("111.222.333-44", aluno.CPF);
            Assert.Equal("11.222.333", aluno.RG);
            Assert.Equal("Masculino", aluno.Sexo);
            Assert.Equal("(00)12345-6789", aluno.Telefone);
        }

        [Fact]
        public void Cpf_nao_nulo()
        {
            var aluno = new Model.Aluno()
            {
                Name = "Varley",
                DataNascimento = "11/22/3333",
                CPF = "",
                RG = "11.222.333",
                Sexo = "Masculino",
                Telefone = "(00)12345-6789"
            };

            Assert.Equal("Varley", aluno.Name);
            Assert.Equal("11/22/3333", aluno.DataNascimento);

            if (aluno.CPF == null)
            {
                Assert.Equal("", aluno.CPF);
            }

            Assert.Equal("11.222.333", aluno.RG);
            Assert.Equal("Masculino", aluno.Sexo);
            Assert.Equal("(00)12345-6789", aluno.Telefone);
        }

        [Fact]
        public void Rg_nao_nulo()
        {
            var aluno = new Model.Aluno()
            {
                Name = "Varley",
                DataNascimento = "11/22/3333",
                CPF = "111.222.333-44",
                RG = "",
                Sexo = "Masculino",
                Telefone = "(00)12345-6789"
            };

            Assert.Equal("Varley", aluno.Name);
            Assert.Equal("11/22/3333", aluno.DataNascimento);
            Assert.Equal("111.222.333-44", aluno.CPF);

            if (aluno.RG == null)
            {
                Assert.Equal("", aluno.RG);
            }

            Assert.Equal("Masculino", aluno.Sexo);
            Assert.Equal("(00)12345-6789", aluno.Telefone);
        }

        [Fact]
        public void Sexo_nao_nulo()
        {
            var aluno = new Model.Aluno()
            {
                Name = "Varley",
                DataNascimento = "11/22/3333",
                CPF = "111.222.333-44",
                RG = "11.222.333",
                Sexo = "",
                Telefone = "(00)12345-6789"
            };

            Assert.Equal("Varley", aluno.Name);
            Assert.Equal("11/22/3333", aluno.DataNascimento);
            Assert.Equal("111.222.333-44", aluno.CPF);
            Assert.Equal("11.222.333", aluno.RG);

            if (aluno.Sexo == null)
            {
                Assert.Equal("", aluno.Sexo);
            }

            Assert.Equal("(00)12345-6789", aluno.Telefone);
        }

        [Fact]
        public void Telefone_nao_nulo()
        {
            var aluno = new Model.Aluno()
            {
                Name = "Varley",
                DataNascimento = "11/22/3333",
                CPF = "111.222.333-44",
                RG = "11.222.333",
                Sexo = "Masculino",
                Telefone = ""
            };

            Assert.Equal("Varley", aluno.Name);
            Assert.Equal("11/22/3333", aluno.DataNascimento);
            Assert.Equal("111.222.333-44", aluno.CPF);
            Assert.Equal("11.222.333", aluno.RG);
            Assert.Equal("Masculino", aluno.Sexo);

            if (aluno.Telefone == null)
            {
                Assert.Equal("", aluno.Telefone);
            }

        }

        [Fact]
        public void Valida_Cpf_Existente()
        {
            string cpf = "111.232.313-44";

            var aluno = new Model.Aluno()
            {
                Id = 1,
                Name = "Varley",
                DataNascimento = "11/22/3333",
                CPF = "111.222.333-44",
                RG = "11.222.333",
                Sexo = "Masculino",
                Telefone = "(31)99878-7290"
            };

            if (aluno.CPF != cpf)
            {
                Assert.Equal("Varley", aluno.Name);
                Assert.Equal("11/22/3333", aluno.DataNascimento);
                Assert.Equal("111.222.333-44", aluno.CPF);
                Assert.Equal("11.222.333", aluno.RG);
                Assert.Equal("Masculino", aluno.Sexo);
            }
            else
            {
                throw new Exception(
                    "CPF já existente");
            }
        }
    }
}
