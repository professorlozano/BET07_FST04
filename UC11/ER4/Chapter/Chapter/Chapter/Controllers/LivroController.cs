using Chapter.Models;
using Chapter.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chapter.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]
    [ApiController]

    [Authorize]
    public class LivroController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;

        public LivroController(LivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_livroRepository.Listar());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                Livro livro = _livroRepository.BuscarPorId(id);

                if(livro == null)
                {
                    return NotFound();
                }
                return Ok(livro);
               
            }
            catch(Exception)
            {
                throw;
            }
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(Livro livro)
        {
            try
            {
                _livroRepository.Cadastrar(livro);
                return StatusCode(201);
            }
            catch(Exception)
            {
                throw;
            }
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Livro livro)
        {
            try
            {
                Livro livroBuscado = _livroRepository.BuscarPorId(id);
                if (livroBuscado == null)
                {
                    return NotFound();
                }
                _livroRepository.Atualizar(id, livro);
                return StatusCode(204);
            }
            catch(Exception)
            {
                throw;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                Livro livroBuscado = _livroRepository.BuscarPorId(id);
                if(livroBuscado == null)
                {
                    return NotFound();
                }
                _livroRepository.Deletar(id);
                return StatusCode(204);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
