using System.ComponentModel.DataAnnotations;

namespace ApiProyecto1002.Models
{
    public class usuarios
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public string? Correo { get; set; }
    }
}
