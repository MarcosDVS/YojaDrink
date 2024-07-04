using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YojaDrink.Interface.Context;
using YojaDrink.Interface.Model;

namespace YojaDrink.Interface.Service;

public class UserService
{
    private readonly MyDbContext dbContext;

    public UserService(MyDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public async Task<Result<List<User>>> Consultar(string filtro)
    {
        try
        {
            var entity = await dbContext.Users
                .Where(c =>
                    (c.Nombre + " " + c.Apellidos + " " + c.Email + " " + c.Role)
                    .ToLower()
                    .Contains(filtro.ToLower())
                )
                .ToListAsync();
            return new Result<List<User>>()
            {
                Message = "Ok",
                Success = true,
                Data = entity
            };
        }
        catch (Exception E)
        {
            return new Result<List<User>>
            {
                Message = E.Message,
                Success = false
            };
        }
    }
    public async Task<Result> Crear(User request)
    {
        try
        {
            dbContext.Users.Add(request);
            await dbContext.SaveChangesAsync();
            return new Result() { Message = "Ok", Success = true };
        }
        catch (Exception E)
        {

            return new Result() { Message = E.Message, Success = false };
        }
    }
    public async Task<Result> Modificar(User request)
    {
        try
        {
            var existing = await dbContext.Users
                .FirstOrDefaultAsync(c => c.Id == request.Id);
            if (existing == null)
                return new Result() { Message = "User not found", Success = false };

            if (existing != null)
            {
                existing.Nombre = request.Nombre;
                existing.Apellidos = request.Apellidos;
                existing.Email = request.Email;
                existing.Password = request.Password;
                existing.Role = request.Role;
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
            var entity = await dbContext.Users
                .FirstOrDefaultAsync(c => c.Id == id);
            if (entity == null)
                return new Result() { Message = "User not found", Success = false };

            dbContext.Users.Remove(entity);
            await dbContext.SaveChangesAsync();
            return new Result() { Message = "Ok", Success = true };
        }
        catch (Exception E)
        {

            return new Result() { Message = E.Message, Success = false };
        }
    }

}
