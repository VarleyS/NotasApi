using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NotaAlunoApi.Data;
using NotaAlunoApi.Data.Dto.UsuarioDto;
using NotaAlunoApi.Migrations;
using NotaAlunoApi.Model;

namespace NotaAlunoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private AlunoContext _context;
        private IMapper _mapper;

        public UsuarioController(IMapper mapper, AlunoContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionaUsuario([FromBody] CreateUsuarioDto usuarioDto)
        {
            Usuario usuario = _mapper.Map<Usuario>(usuarioDto);
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaUsuarioPorId), new { Id = usuario.Id }, usuarioDto);
        }

        [HttpGet]
        public IEnumerable<ReadUsuarioDto> RetornaUsuarios()
        {
            return _mapper.Map<List<ReadUsuarioDto>>(_context.Usuarios.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaUsuarioPorId(int id)
        {
            var usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.Id == id);
            if(usuario != null)
            {
                ReadUsuarioDto usuarioDto = _mapper.Map<ReadUsuarioDto>(usuario);
                return Ok(usuarioDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaUsuario(int id, [FromBody] UpdateUsuarioDto usuarioDto)
        {
            var usuario = _context.Usuarios.FirstOrDefault(usuario =>usuario.Id == id);
            if(usuario == null)
            {
                return NotFound();
            }
            _mapper.Map(usuarioDto, usuario);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveUsuario(int id) 
        {
            var usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.Id == id);
            if(usuario == null)
            {
                return NotFound();
            }
            _context.Remove(usuario);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
