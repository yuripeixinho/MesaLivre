using MesaLivre.Models;
using MesaLivre.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace MesaLivre.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestauranteController : ControllerBase
    {
        private readonly IRestauranteRepository _restauranteRepository;

        public RestauranteController(IRestauranteRepository restauranteRepository)
        {
            _restauranteRepository = restauranteRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var restaurantes = await _restauranteRepository.GetAll();

            return Ok(restaurantes);
        }

        //[HttpGet]
        //public async Task<IActionResult> GetById()
        //{
        //    //var restaurantes = await _restauranteRepository.GetAll();

        //    return Ok("oi");
        //}

        //[HttpPost]
        //public async Task<ActionResult<Restaurante>> Create([FromBody] RestauranteCreateDTO restauranteDto)
        //{

        //    using var transaction = await 

        //    var restaurante = new Restaurante
        //    {
        //        Nome = restauranteDto.Nome,
        //        HoraAbertura = restauranteDto.HoraAbertura,
        //        HoraFechamento = restauranteDto.HoraFechamento,
        //    };

        //    await _restauranteRepository.Add(restaurante);

        //    return CreatedAtAction("GetAll", new { id = restaurante.Id }, restaurante);
        //}

        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
