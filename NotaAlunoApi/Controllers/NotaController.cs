using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NotaAlunoApi.Data;
using NotaAlunoApi.Data.Dto.NotaDto;
using NotaAlunoApi.Model;

namespace NotaAlunoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotaController : ControllerBase
    {
        private AlunoContext _context;
        private IMapper _mapper;

        public NotaController(AlunoContext alunoContext, IMapper mapper) 
        {
            _context = alunoContext;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaNotas([FromBody] CreateNotaDto notaDto)
        {
            Nota nota = _mapper.Map<Nota>(notaDto);
            _context.Notas.Add(nota);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaNotaPorId), new { id = nota.Id }, nota);
        }

        [HttpGet]
        public IEnumerable<ReadNotaDto> RetornaNotas()
        {
            return _mapper.Map<List<ReadNotaDto>>(_context.Notas);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaNotaPorId(int id)
        {
            var nota = _context.Notas.FirstOrDefault(nota => nota.Id == id);
            if (nota == null)
            {
                return NotFound();
            }
            var notaDto = _mapper.Map<ReadNotaDto>(nota);
            return Ok(notaDto);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaNota(int id, [FromBody] UpdateNotaDto notaDto)
        {
            var nota = _context.Notas.FirstOrDefault(nota => nota.Id == id);
            if(nota == null)
            {
                return NotFound();
            }
            _mapper.Map(notaDto, nota);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaNota(int id)
        {
            var nota = _context.Notas.FirstOrDefault(nota => nota.Id == id);
            if(null == nota)
            {
                return NotFound();
            }
            _context.Remove(nota);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
