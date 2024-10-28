using System.ComponentModel.DataAnnotations;

namespace AlmeidaSebastian_ExamenProgreso1.Models
{
    public class Celular{
        [Key]
        public int Id { get; set; }
        [Required]
        public int Numero { get; set; }
        [MaxLength(100)]
        public string Modelo { get; set; }
        [Range (1950, 2025, ErrorMessage = "Ingrese una fecha válida")]
        public int Anio { get; set; }
        [Range (0, 10000, ErrorMessage = "Ingrese un precio válido")]
        public float Precio { get; set; }
    }
}
