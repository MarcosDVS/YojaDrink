using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YojaDrink.Interface.Model;

public class Product
{
    [Key]
    public int Id { get; set; }
    public string? BarCode { get; set; }
    public string Description { get; set; } = string.Empty;
    public int Stock { get; set; }
    public decimal PurchasePrice { get; set; }
    public decimal SellingPrice { get; set; }
}
