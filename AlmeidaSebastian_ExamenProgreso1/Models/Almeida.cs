using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlmeidaSebastian_ExamenProgreso1.Models
{
    public class Almeida{
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Range (0, 200, ErrorMessage = "Ingrese el peso en KG")]
        public float Peso { get; set; }
        [Required]
        public bool DonanteOrganos {  get; set; }
        public DateTime Fecha { get; set; }
        [ForeignKey("Celular")]
        [Display(Name = "Número celular")]
        public int IdCelular { get; set; }
        public Celular celular { get; set; }
    }
}
