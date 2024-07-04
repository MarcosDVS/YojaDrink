using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YojaDrink.Interface.Context;
using YojaDrink.Interface.Model;

namespace YojaDrink.Interface.Service;

public class CustomerService
{
    private readonly MyDbContext dbContext;

    public CustomerService(MyDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public async Task<Result<List<Customer>>> Consultar(string filtro)
    {
        try
        {
            var entity = await dbContext.Customers
                .Where(c =>
                    (c.Name + " " + c.SurNames + " " + c.PhoneNumber + " " + c.DocumentId)
                    .ToLower()
                    .Contains(filtro.ToLower()
                    )
                )
                .ToListAsync();
            return new Result<List<Customer>>()
            {
                Message = "Ok",
                Success = true,
                Data = entity
            };
        }
        catch (Exception E)
        {
            return new Result<List<Customer>>
            {
                Message = E.Message,
                Success = false
            };
        }
    }
    public async Task<Result> Crear(Customer request)
    {
        try
        {
            dbContext.Customers.Add(request);
            await dbContext.SaveChangesAsync();
            return new Result() { Message = "Ok", Success = true };
        }
        catch (Exception E)
        {

            return new Result() { Message = E.Message, Success = false };
        }
    }
    public async Task<Result> Modificar(Customer request)
    {
        try
        {
            var existing = await dbContext.Customers
                .FirstOrDefaultAsync(c => c.Id == request.Id);
            if (existing == null)
                return new Result() { Message = "Customer not found", Success = false };

            if (existing != null)
            {
                existing.DocumentId = request.DocumentId;
                existing.Name = request.Name;
                existing.SurNames = request.SurNames;
                existing.PhoneNumber = request.PhoneNumber;
                existing.Other = request.Other;
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
            var entity = await dbContext.Customers
                .FirstOrDefaultAsync(c => c.Id == id);
            if (entity == null)
                return new Result() { Message = "Customer not found", Success = false };

            dbContext.Customers.Remove(entity);
            await dbContext.SaveChangesAsync();
            return new Result() { Message = "Ok", Success = true };
        }
        catch (Exception E)
        {

            return new Result() { Message = E.Message, Success = false };
        }
    }

}
