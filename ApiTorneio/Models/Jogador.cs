using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTorneio.Models
{
    public class Jogador
    {
        [Key]
        public int JogadorId { get; set; }

        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Required]
        public string Nome { get; set; }

        [Required]
        public string DataNascimento { get; set; }

        public virtual Time Time { get; set; }

        [ForeignKey("Time")]
        public int TimeId { get; set; }

    }
}
