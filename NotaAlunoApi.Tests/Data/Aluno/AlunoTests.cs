using NotaAlunoApi.Data.Dto;
using NotaAlunoApi.Model;

namespace NotaAlunoApi.Tests.Data.Aluno
{
    public class AlunoTests
    {
        [Fact]
        public void Create_Aluno_Correto() 
        {
            var aluno = new Model.Aluno()
            {
                Name = "Varley",
                DataNascimento = "31/12/1991",
                CPF = "100.223.076-48",
                RG = "16.085.397",
                Sexo = "Masculino",
                Telefone = "(31)99878-7290"
            };

            Assert.Equal("Varley", aluno.Name);
            Assert.Equal("31/12/1991", aluno.DataNascimento);
            Assert.Equal("100.223.076-48", aluno.CPF);
            Assert.Equal("16.085.397", aluno.RG);
            Assert.Equal("Masculino", aluno.Sexo);
            Assert.Equal("(31)99878-7290", aluno.Telefone);
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
    }
}
