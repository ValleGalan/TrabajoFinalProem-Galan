using System.ComponentModel.DataAnnotations; //para el key 

namespace TrabajoFinalProem_GalanFlorencia.Models
{
    public class Cliente
    {
         [Key]
        public int codigo { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre del cliente")]
        public string? nombre { get; set; }
        [Required(ErrorMessage = "La direccion es obligatorio")]
        [Display(Name = "Direccion del cliente")]
        public string? direccion { get; set; }

        [Display(Name = "Extra saldo de la cuenta corriente")]
        public float? extraSaldo { get; set; }  //extra-saldo de la cuenta corriente
        //vincular con la tabla factura: cliente tiene varias facturas




        //relacion de uno a muchos
      //  public List<Factura> Factura { get; set; }// ayuda a navegar de cliente a factura
        public int FacturaId { get; set; }
        public virtual Factura? FacturaIdNavigation { get; set; }
        //constructor
        public Cliente(int codigo,string nombre,string direccion,float? extraSaldo,int FacturaId )
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.direccion = direccion;
            this.extraSaldo = extraSaldo;
            this.FacturaId = FacturaId;
           
        }
    }
}
