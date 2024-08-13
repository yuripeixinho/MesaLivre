using System.ComponentModel.DataAnnotations;

namespace MesaLivre.Models.DTOS.Restaurante;

public class RestauranteDetailDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string? HoraAbertura { get; set; }
    public string? HoraFechamento { get; set; }

    public Endereco Endereco { get; set; }
}
