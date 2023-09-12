using System.ComponentModel.DataAnnotations;

namespace NotaAlunoApi.Model
{
    public class Usuario
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage ="Campo obrigatório!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }
}
