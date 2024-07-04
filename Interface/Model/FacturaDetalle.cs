using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YojaDrink.Interface.Model;

public class FacturaDetalle
{
    [Key]
    public int Id { get; set; }
    public int FacturaId { get; set; }
    public int ProductoId { get; set; }
    public int Cantidad { get; set; } = 1;
    [Column(TypeName = "decimal(18,2)")]
    public decimal Precio { get; set; }

    #region Relaciones
    [ForeignKey(nameof(FacturaId))]
    public virtual Factura? Factura { get; set; }
    [ForeignKey(nameof(ProductoId))]
    public virtual Product? Producto { get; set; }
    #endregion

    [NotMapped]
    public decimal SubTotal => Cantidad * Precio;
}
