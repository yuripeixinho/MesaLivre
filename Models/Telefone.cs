using MesaLivre.Utils;
using System.ComponentModel.DataAnnotations;

namespace MesaLivre.Models
{
    public class Telefone
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(3, ErrorMessage = "O DDD deve conter 3 caracteres.")]
        public string DDD { get; set; }
        public string Numero { get; set; }

        public int TipoTelefoneID { get; set; }
        public int RestauranteID { get; set; }
        public TelefoneTipo TelefoneTipo { get; set; }
        public Restaurante Restaurante { get; set; }
    }
}
