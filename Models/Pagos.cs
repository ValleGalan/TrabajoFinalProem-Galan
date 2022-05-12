using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace TrabajoFinalProem_GalanFlorencia.Models
{
    public partial class Pagos
    {

        [Key]
        public int id { get; set; }

        [Display(Name = "Fecha creacion")]
        public DateTime? FechaCreacion { get; set; }
        public float? importe { get; set; }
        //vincular con la tabla factura
        public Pagos()
        {
            Facturas = new HashSet<Factura>();
        }
        public virtual ICollection<Factura> Facturas { get; set; }


        // public int FacturaId { get; set; }

        



    }
}
