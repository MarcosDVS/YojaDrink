using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YojaDrink.Interface.Model;

public class Customer
{
    [Key]
    public int Id { get; set; }
    public string DocumentId { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string SurNames { get; set; } = null!;
    public string? PhoneNumber { get; set; }
    public string? Other { get; set; }

    #region Relaciones
    public virtual ICollection<Factura>? Facturas { get; set; }
    #endregion
}
