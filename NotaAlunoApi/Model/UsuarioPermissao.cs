namespace NotaAlunoApi.Model
{
    public class UsuarioPermissao
    {
        public UsuarioPermissao(int usuarioId, int permissaoId)
        {
            Validation(usuarioId, permissaoId);
        }

        public int Id { get; private set; }
        public int UsuarioId { get; private set; }
        public int PermissaoId { get; private set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Permissao Permissao { get; set; }

        private void Validation(int usuarioId, int permissaoId)
        {
            if (usuarioId == 0)
            {
                Console.WriteLine("Usuário Id deve ser informado!");
            }
            if (permissaoId == 0)
            {
                Console.WriteLine("Permissão Id deve ser informado!");
            }

            UsuarioId = usuarioId;
            PermissaoId = permissaoId;
        }
    }
}
