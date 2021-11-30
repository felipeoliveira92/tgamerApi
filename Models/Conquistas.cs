using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using tgamerApi.Dto;

namespace tgamerApi.Models
{
    public class Conquistas
    {
        public Conquistas()
        {

        }
        public Conquistas(Conquistas conquista)
        {
            this.UsuarioId = conquista.UsuarioId;
            this.acertos = conquista.acertos;
            this.erros = conquista.erros;
            this.nivel = conquista.nivel;
        }
        public void Put(int id, Conquistas conquista)
        {
            this.acertos = conquista.acertos;
            this.erros = conquista.erros;
            this.nivel = conquista.nivel;

        }

        [Key]
        public int Id { get; set; }        
        public int? UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
        public int acertos { get; set; }
        public int erros { get; set; }
        public int nivel { get; set; }
    }
}