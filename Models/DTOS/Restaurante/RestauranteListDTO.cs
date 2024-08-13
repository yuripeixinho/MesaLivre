namespace MesaLivre.Models.DTOS.Restaurante;

public class RestauranteListDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string HoraAbertura { get; set; }
    public string HoraFechamento { get; set; }
    public int EnderecoID { get; set; } 
}
