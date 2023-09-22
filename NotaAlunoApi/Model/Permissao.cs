using System.Linq.Expressions;

namespace NotaAlunoApi.Model
{
    public class Permissao
    {

        public Permissao(string nomeVisual, string nomePermissao)
        {
            Validation(nomeVisual, nomePermissao);
            UsuarioPermissao = new List<UsuarioPermissao>();
        }

        public int Id { get; private set; }
        public string NomeVisual {get; private set;}
        public string NomePermissao { get; private set;}
        public virtual ICollection<UsuarioPermissao> UsuarioPermissao { get; private set;}

        private void Validation(string nomeVisual, string nomePermissao)
        {
            if (string.IsNullOrEmpty(nomeVisual))
            {
                Console.WriteLine("Nome visual deve ser informado!");
            }
            if (string.IsNullOrEmpty(nomePermissao))
            {
                Console.WriteLine("Nome permissao deve ser informado!");
            }

            NomeVisual = nomeVisual;
            NomePermissao = nomePermissao;
        }
    }
}
