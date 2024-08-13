using MesaLivre.Models;
using MesaLivre.Models.DTOS.Restaurante;
using MesaLivre.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace MesaLivre.Controllers
{
    [Route("restaurantes")]
    [ApiController]
    public class RestauranteController : ControllerBase
    {
        private readonly IRestauranteRepository _restauranteRepository;

        public RestauranteController(IRestauranteRepository restauranteRepository)
        {
            _restauranteRepository = restauranteRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<RestauranteListDTO>>> GetAll()
        {
            var restaurantes = await _restauranteRepository.GetAll();

            var restauranteDTOs = restaurantes.Select(r => new RestauranteListDTO
            {
                Id = r.Id,
                Nome = r.Nome,
                HoraAbertura = r.HoraAbertura.ToString(@"hh\:mm"),
                HoraFechamento = r.HoraFechamento.ToString(@"hh\:mm"),
                EnderecoID = r.EnderecoID
            }).ToList();
                
            return Ok(restauranteDTOs);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<RestauranteDetailDTO>> GetById(int id)
        {
            var restaurante = await _restauranteRepository.GetRestauranteById(id);

            var restauranteDto = new RestauranteDetailDTO
            {
                Id = restaurante.Id,
                Nome = restaurante.Nome,
                HoraAbertura = restaurante.HoraAbertura.ToString(@"hh\:mm"),
                HoraFechamento = restaurante.HoraFechamento.ToString(@"hh\:mm"),
                Endereco = restaurante.Endereco,
            };
            return Ok(restauranteDto);
        }

        [HttpPost]
        public async Task<ActionResult<Restaurante>> Create([FromBody] RestauranteCreateDTO restauranteDto)
        {
            var restaurante = new Restaurante
            {
                Nome = restauranteDto.Nome,
                HoraAbertura = restauranteDto.HoraAbertura,
                HoraFechamento = restauranteDto.HoraFechamento,
                EnderecoID = restauranteDto.EnderecoID
            };
            
            await _restauranteRepository.Insert(restaurante);

            return CreatedAtAction("GetAll", new { id = restaurante.Id }, restaurante);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Restaurante>> Put(int id, [FromBody] RestauranteUpdateDTO updatedRestaurante)
        {
            if (updatedRestaurante is null)
                return BadRequest("Dados inválidos");

            var existingRestaurante = await _restauranteRepository.GetRestauranteById(id);

            existingRestaurante.Nome = updatedRestaurante.Nome ?? existingRestaurante.Nome;
            existingRestaurante.HoraAbertura = updatedRestaurante.HoraAbertura ?? existingRestaurante.HoraAbertura;
            existingRestaurante.HoraFechamento = updatedRestaurante?.HoraFechamento ?? existingRestaurante.HoraFechamento;
            existingRestaurante.EnderecoID = updatedRestaurante?.EnderecoID ?? existingRestaurante.EnderecoID;

            var updateEntity = await _restauranteRepository.Update(existingRestaurante);

            return Ok(updateEntity);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var restaurante = await _restauranteRepository.Delete(id);

            if (!restaurante)
                return NotFound();

            return NoContent(); // Retorna 204 No Content para exclusão bem-sucedida
        }
    }
}
