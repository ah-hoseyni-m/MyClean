using Application.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> SaveChangeAsync()
        {
           return  Convert.ToBoolean(await _dbContext.SaveChangesAsync());
        }

        public async Task<bool> SaveChange()
        {
            return Convert.ToBoolean(_dbContext.SaveChanges());
        }
    }
}
