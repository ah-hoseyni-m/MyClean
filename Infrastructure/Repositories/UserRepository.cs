using Domain.Entities;
using Domain.Repository;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Create(User model)
        {
            await _dbContext.AddAsync(model);
            //await _dbContext.SaveChangesAsync();
            return model.Id;
        }

        public async Task<int> Edit(User model)
        {
            var entity = _dbContext.Users.Where(x => x.Id == model.Id).FirstOrDefault();
            entity.Family = model.Name;
            entity.Family = model.Family;
            _dbContext.Entry(entity).State = EntityState.Modified;

            //    UserName = model.UserName,
            //    Email = model.Email,
            //    CreateAt = DateTime.Now,
            //    Gender = model.Gender,
            //    Family = model.Family,
            //    Name = model.Name,
            //    PasswordHash = model.PasswordHash

            return model.Id;
        }

        public async Task SaveChangeAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
