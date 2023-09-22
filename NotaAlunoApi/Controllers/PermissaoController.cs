using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NotaAlunoApi.Data;
using NotaAlunoApi.Data.Dto.Permissao;
using NotaAlunoApi.Data.Dto.UsuarioDto;
using NotaAlunoApi.Model;

namespace NotaAlunoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PermissaoController : ControllerBase
    {
        private AlunoContext _context;
        private IMapper _mapper;

        public PermissaoController(AlunoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaPermissao([FromBody] CreatePermissaoDto permissaoDto)
        {
            Permissao permissao = _mapper.Map<Permissao>(permissaoDto);
            _context.Permissaos.Add(permissao);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaPermissaoPorId), new { Id = permissao.Id }, permissaoDto);
        }

        [HttpGet]
        public IEnumerable<ReadPermissaoDto> RecuperaPermissoes()
        {
            return _mapper.Map<List<ReadPermissaoDto>>(_context.Permissaos.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaPermissaoPorId(int id) 
        {
            var permissao = _context.Permissaos.FirstOrDefault(p => p.Id == id);
            if (permissao != null)
            {
                ReadPermissaoDto permissaoDto = _mapper.Map<ReadPermissaoDto>(permissao);
                return Ok(permissaoDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaPermissao(int id, [FromBody] UpdatePermissaoDto permissaoDto)
        {
            var permissao = _context.Usuarios.FirstOrDefault(p => p.Id == id);
            if (permissao == null)
            {
                return NotFound();
            }
            _mapper.Map(permissaoDto, permissao);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveUsuario(int id)
        {
            var permissao = _context.Usuarios.FirstOrDefault(p => p.Id == id);
            if (permissao == null)
            {
                return NotFound();
            }
            _context.Remove(permissao);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
