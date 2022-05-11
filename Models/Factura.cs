using System.ComponentModel.DataAnnotations;

namespace TrabajoFinalProem_GalanFlorencia.Models
{
    public class Factura
    {
        [Key]
        [Required]
        public int numero { get; set; }

        public int IDCliente { get; set; }

        [Display(Name = "Fecha creacion")]
        public DateTime FechaCreacion { get; set; }
        //vincular con el cliente
        public Factura()
        {
            this.Cliente = new HashSet<Cliente>();
        }
        public int CodigoCliente { get; set; }
       // public Cliente Cliente { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set;} 
       
        public int PagosId { get; set; }
        public HashSet<Cliente> Cliente { get; private set; }

        //para ITEMS

        // public virtual ICollection<Cliente> Items { get; set; }
        /**
                 codigo
        desc
        cantidad
        precio
    extra- cantidad de items dinamicos

         */

    }
}
