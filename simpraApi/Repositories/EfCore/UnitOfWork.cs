using Entities.Models;
using Repositories.Context;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EfCore
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SimpDbContext _dbContext;
        private bool disposed;

        public UnitOfWork(SimpDbContext dbContext)
        {
            _dbContext = dbContext;
            Staff = new StaffRepository(_dbContext);
        }

        public IStaffRepository Staff { get; private set; }

        public async Task<int> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void SaveWithTransaction()
        {
            using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    _dbContext.SaveChanges();
                    dbContextTransaction.Commit();
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    throw new Exception("Transaction failed. Changes rolled back.", ex);
                }
            }
        }
        private void Clean(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            disposed = true;
            GC.SuppressFinalize(this);
        }

        public void Dispose()
        {
            Clean(true);
        }

    }
}
