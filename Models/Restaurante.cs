using System.ComponentModel.DataAnnotations;

namespace MesaLivre.Models;

public class Restaurante
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Nome { get; set; }
    public DateTime HoraAbertura { get; set; }
    public DateTime HoraFechamento { get; set; }

    public int EnderecoID { get; set; }
    public Endereco Endereco { get; set; } 
    public ICollection<Telefone> Telefones { get; set; }
}
