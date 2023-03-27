using System.ComponentModel.DataAnnotations;

namespace Guia2.Models
{
    public class marcas
    {
        [Key]
        public int id_marcas { get; set; }
        public string? nombre_marca { get; set; }
        public char estado { get; set; }

    }
}
