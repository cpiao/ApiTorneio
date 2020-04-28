using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiTorneio.Models
{
    public class PartidaTime
    {

        [Key]
        public int PartidaTimeId { get; set; }

        [StringLength(30, ErrorMessage = "Máximo 30 caracteres.")]
        [Required]
        public string Titulo { get; set; }

        public virtual Time Time { get; set; }
    }
}
