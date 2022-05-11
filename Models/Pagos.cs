using System.ComponentModel.DataAnnotations;

namespace TrabajoFinalProem_GalanFlorencia.Models
{
    public class Pagos
    {

        [Key]
        public int id { get; set; }

        [Display(Name = "Fecha creacion")]
        public DateTime FechaCreacion { get; set; }
        public int IDCliente { get; set; }
        public float importe { get; set; }
        //vincular con la tabla factura
       // public virtual ICollection<Factura> Factura { get; set; }
        public Pagos()
        {
            this.Factura = new HashSet<Factura>();
        }
        public int NumeroFactura { get; set; }
      
        public HashSet<Factura> Factura { get; private set; }



    }
}
