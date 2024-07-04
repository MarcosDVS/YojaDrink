using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YojaDrink.Interface.Model;

public class FacturaPago
{
    public int Id { get; set; }
    public int FacturaId { get; set; }
    public DateTime Date { get; set; }
    public decimal AmountPaid { get; set; }
    public string Observation { get; set; }

    #region Relaciones
    [ForeignKey(nameof(FacturaId))]
    public virtual Factura? Factura { get; set; }
    #endregion
}
