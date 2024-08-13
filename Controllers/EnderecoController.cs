using MesaLivre.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MesaLivre.Controllers
{
    [Route("enderecos")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoController(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var enderecos = await _enderecoRepository.GetAll();

            return Ok(enderecos);
        }

    }
}
