using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YojaDrink.Interface.Context;
using YojaDrink.Interface.Model;

namespace YojaDrink.Interface.Service;

public class ProductService
{
    private readonly MyDbContext dbContext;

    public ProductService(MyDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public async Task<Result<List<Product>>> Consultar(string filtro)
    {
        try
        {
            var entity = await dbContext.Products
                .Where(c =>
                    (c.Description + " " + c.BarCode)
                    .ToLower()
                    .Contains(filtro.ToLower()
                    )
                )
                .ToListAsync();
            return new Result<List<Product>>()
            {
                Message = "Ok",
                Success = true,
                Data = entity
            };
        }
        catch (Exception E)
        {
            return new Result<List<Product>>
            {
                Message = E.Message,
                Success = false
            };
        }
    }
    public async Task<Result> Crear(Product request)
    {
        try
        {
            dbContext.Products.Add(request);
            await dbContext.SaveChangesAsync();
            return new Result() { Message = "Ok", Success = true };
        }
        catch (Exception E)
        {

            return new Result() { Message = E.Message, Success = false };
        }
    }
    public async Task<Result> Modificar(Product request)
    {
        try
        {
            var existing = await dbContext.Products
                .FirstOrDefaultAsync(c => c.Id == request.Id);
            if (existing == null)
                return new Result() { Message = "Product not found", Success = false };

            if (existing != null)
            {
                existing.BarCode = request.BarCode;
                existing.Description = request.Description;
                existing.Stock = request.Stock;
                existing.PurchasePrice = request.PurchasePrice;
                existing.SellingPrice = request.SellingPrice;
                dbContext.SaveChanges();
            }

            return new Result() { Message = "Ok", Success = true };
        }
        catch (Exception E)
        {

            return new Result() { Message = E.Message, Success = false };
        }
    }
    public async Task<Result> Eliminar(int? id)
    {
        try
        {
            var entity = await dbContext.Products
                .FirstOrDefaultAsync(c => c.Id == id);
            if (entity == null)
                return new Result() { Message = "Product not found", Success = false };

            dbContext.Products.Remove(entity);
            await dbContext.SaveChangesAsync();
            return new Result() { Message = "Ok", Success = true };
        }
        catch (Exception E)
        {

            return new Result() { Message = E.Message, Success = false };
        }
    }

}
