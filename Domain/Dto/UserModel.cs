using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto;

public record UserModel
(
    int id ,
    string Name,
    string Family ,
    string Email ,
    string PasswordHash ,
    string UserName ,
    GenderType Gender 
);
