using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YojaDrink.Interface.Model;

public class User
{
    [Key]
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public string Apellidos { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string? Role { get; set; }
}
