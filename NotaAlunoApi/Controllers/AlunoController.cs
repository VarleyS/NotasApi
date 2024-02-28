using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NotaAlunoApi.Data;
using NotaAlunoApi.Data.Dto;
using NotaAlunoApi.Model;

namespace NotaAlunoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        private AlunoContext _context;
        private IMapper _mapper;

        public AlunoController(AlunoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaAluno([FromBody] CreateAlunoDto alunoDto)
        {
            Aluno aluno = _mapper.Map<Aluno>(alunoDto);
            var validaAluno = _context.Alunos.FirstOrDefault(aluno => aluno.CPF == alunoDto.CPF);
            if (validaAluno == null)
            {
                _context.Alunos.Add(aluno);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("CPF já existente");
            }
            return CreatedAtAction(nameof(RecuperaAlunoPorId), new { Id = aluno.Id }, alunoDto);
        }

        [HttpGet]
        public IEnumerable<ReadAlunoDto> RecuperaAlunos()
        {
            return _mapper.Map<List<ReadAlunoDto>>(_context.Alunos.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaAlunoPorId(int id)
        {
            Aluno aluno = _context.Alunos.FirstOrDefault(aluno => aluno.Id == id);
            if (aluno != null)
            {
                ReadAlunoDto alunoDto = _mapper.Map<ReadAlunoDto>(aluno);
                return Ok(alunoDto);
            }
            return NotFound();
        }

        [HttpPut]
        public IActionResult AtualizaAluno(int id, [FromBody] UpdateAlunoDto alunoDto)
        {
            Aluno aluno = _context.Alunos.FirstOrDefault(aluno => aluno.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }
            _mapper.Map(alunoDto, aluno);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeletaAluno(int id)
        {
            Aluno aluno = _context.Alunos.FirstOrDefault(aluno => aluno.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }
            _context.Remove(aluno);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
