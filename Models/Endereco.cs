using System.ComponentModel.DataAnnotations;

namespace MesaLivre.Models;

public class Endereco
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string CEP { get; set; }
    [Required]
    public string Rua { get; set; }
    [Required]
    public string Numero { get; set; }
    public string Complemento { get; set; }
    public string Bairro { get; set; }
    [Required]
    public string Cidade { get; set; }
    [Required]
    public string Estado { get; set; }
}
