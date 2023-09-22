using System.ComponentModel.DataAnnotations;

namespace NotaAlunoApi.Model
{
    public class Usuario
    {
        public Usuario(string name, string email, string password)
        {
            Validation(name, email, password);
            UsuarioPermissao = new List<UsuarioPermissao>();
        }

        public Usuario(int id, string name, string email, string password)
        {
            if (id == 0)
            {
                Console.WriteLine("Id deve ser informado!");
            }
            Id = id;
            Validation(name, email, password);
            UsuarioPermissao = new List<UsuarioPermissao>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<UsuarioPermissao> UsuarioPermissao { get; set; }

        private void Validation(string name, string email, string password)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (email == null)
            {
                throw new ArgumentNullException("email");
            }
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
