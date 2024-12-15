using System.ComponentModel.DataAnnotations;
namespace PracticaClase.Models
{
    public class Producto
    {
        [Key]
        public int Codigo { get; set; } //PK
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public double Existencia { get; set; }
        public double Iva { get; set; }

        
        public int ProveedorCodigo { get; set; } // FK

        public Proveedor Proveedor { get; set; }


    }
}

