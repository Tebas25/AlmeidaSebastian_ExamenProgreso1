using System.ComponentModel.DataAnnotations;

namespace AlmeidaSebastian_ExamenProgreso1.Models
{
    public class Celular{
        [Key]
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public float Precio { get; set; }
    }
}
