using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class User : BaseEntity
{
    public string Name { get; set; }
    public string Family { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string UserName { get; set; }
    public GenderType Gender { get; set; }

}
public enum GenderType
{
    [Display(Name = "مرد")]
    Male = 1,

    [Display(Name = "زن")]
    Female = 2
}
