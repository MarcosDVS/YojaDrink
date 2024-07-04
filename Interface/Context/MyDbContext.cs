using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YojaDrink.Interface.Model;

namespace YojaDrink.Interface.Context;

public class MyDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Factura> Facturas { get; set; }
    public DbSet<FacturaDetalle> FacturaDetalles { get; set; }
    public DbSet<FacturaPago> FacturaPagos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer
            (
                @"Server=.;
                Initial Catalog=DrinkDB;
                Persist Security Info=False;
                TrustServerCertificate=true;
                Integrated Security=true;"
            );
        }
    }
}
