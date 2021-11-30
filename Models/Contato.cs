using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tgamerApi.Models
{
    public class Contato
    {
        public Contato()
        {

        }


        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string nome { get; set; }

        [MaxLength(13)]
        [Required]
        public string celular { get; set; }
                
        public int usuarioId { get; set; }

        [ForeignKey("usuarioId")]
        public Usuario Usuario { get; set; }
    }
}