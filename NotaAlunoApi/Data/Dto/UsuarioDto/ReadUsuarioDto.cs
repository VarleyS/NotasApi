namespace NotaAlunoApi.Data.Dto.UsuarioDto
{
    public class ReadUsuarioDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }
}
