using System.ComponentModel.DataAnnotations;

namespace MesaLivre.Models.DTOS.Restaurante;

public class RestauranteCreateDTO
{
    public string Nome { get; set; }
    public TimeSpan HoraAbertura { get; set; }
    public TimeSpan HoraFechamento { get; set; }

    public int EnderecoID { get; set; }
}
