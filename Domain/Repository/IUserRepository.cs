using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository;

public interface IUserRepository 
{
    Task<int> Create(User model);
    Task<int> Edit(User model);
}
