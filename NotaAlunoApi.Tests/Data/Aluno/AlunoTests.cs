using NotaAlunoApi.Data.Dto;
using NotaAlunoApi.Model;

namespace NotaAlunoApi.Tests.Data.Aluno
{
    public class AlunoTests
    {
        [Fact]
        public void Create_Aluno_Falso() 
        {
            var aluno1 = new Model.Aluno()
            {
                Name = "A",
                DataNascimento = "31/12/1991",
                CPF = "100.223.076-48",
                RG = "16.085.397",
                Sexo = "Masculino",
                Telefone = "(31)99878-7290"
            };

            Assert.Equal("A", aluno1.Name);
            Assert.Equal("31/12/1991", aluno1.DataNascimento);
            Assert.Equal("100.223.076-48", aluno1.CPF);
        }
    }
}
