using System.ComponentModel.DataAnnotations;
namespace PracticaClase.Models
{
    public class Proveedor
    {
        [Key]
        public int Codigo { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Ruc { get; set; }

        public List<Producto> Productos { get; set; }
    }
}
