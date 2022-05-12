using System.ComponentModel.DataAnnotations;

namespace TrabajoFinalProem_GalanFlorencia.Models
{
    public class Factura
    {
        [Key]
        [Required]
        [Display(Name = "ID Factura")]
        public int numero { get; set; }

        [Display(Name = "Fecha creacion")]
        public DateTime? FechaCreacion { get; set; }

        //vincular con el cliente 
        public Factura()
        {
            Clientes = new HashSet<Cliente>();
        }
        [Display(Name = "id Cliente")]

        public virtual ICollection<Cliente> Clientes { get; set; }
       // public int ClienteId { get; set; } //foranea
        //vincular con pagos -Relacion uno a uno
        [Display(Name = " Pagos")]
        public int? PagosId { get; set; }
        public virtual Pagos? PagosIdNavigation { get; set; }


       // public Pagos Pagos { get; set; }
        


    }
}
