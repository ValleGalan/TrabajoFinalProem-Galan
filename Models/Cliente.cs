using System.ComponentModel.DataAnnotations; //para el key 

namespace TrabajoFinalProem_GalanFlorencia.Models
{
    public class Cliente
    {
         [Key]
        public int codigo { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre del cliente")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "La direccion es obligatorio")]
        [Display(Name = "Direccion del cliente")]
        public string direccion { get; set; }

        [Display(Name = "Extra saldo de la cuenta corriente")]
        public float extraSaldo { get; set; }  //extra-saldo de la cuenta corriente
        //vincular con la tabla facturas
        public virtual Factura FacturaNumero { get; set; }
        /*
        public HashSet<Factura> Factura { get; private set; }

        public Cliente()
        {
            this.Factura = new HashSet<Factura>();
        }

        /*/
    }
}
