using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MesaLivre.Models;

public class Restaurante
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Nome { get; set; }
    public TimeSpan HoraAbertura { get; set; }
    public TimeSpan HoraFechamento { get; set; }

    [ForeignKey("Endereco")]
    public int EnderecoID { get; set; }


    public Endereco Endereco { get; set; } 
    public ICollection<Telefone> Telefones { get; set; }
}
