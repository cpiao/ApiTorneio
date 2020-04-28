using System.ComponentModel.DataAnnotations;

namespace ApiTorneio.Models
{
    public class Time
    {
        [Key]
        public int TimeId { get; set; }

        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Required]
        public string Nome { get; set; }

        public virtual Jogador Jogador { get; set; }

    }
}
