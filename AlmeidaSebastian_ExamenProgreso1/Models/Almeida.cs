using System.ComponentModel.DataAnnotations.Schema;

namespace AlmeidaSebastian_ExamenProgreso1.Models
{
    public class Almeida{
        public string Id { get; set; }
        public string Nombre { get; set; }
        public float Decimal { get; set; }
        public bool DonanteOrganos {  get; set; }
        public DateTime Fecha { get; set; }
        [ForeignKey("Celular")]
        public Celular celular { get; set; }
        public int IdCelular { get; set; }
    }
}
