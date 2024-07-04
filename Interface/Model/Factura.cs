using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YojaDrink.Interface.Model;

public class Factura
{
    [Key]
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime Fecha { get; set; }

    #region Relaciones
    [ForeignKey(nameof(CustomerId))]
    public virtual Customer? Customer { get; set; }
    public virtual ICollection<FacturaDetalle>? Detalles { get; set; }
    public virtual ICollection<FacturaPago>? FacturaPagos { get; set; }
    #endregion

    [NotMapped]
    public decimal SubTotal =>
        Detalles != null ? //IF
        Detalles.Sum(d => d.SubTotal) //Verdadero
        :
        0;//Falso
    public decimal AmountPaid =>
        FacturaPagos != null ? //IF
        FacturaPagos.Sum(d => d.AmountPaid) //Verdadero
        :
        0;//Falso
}
