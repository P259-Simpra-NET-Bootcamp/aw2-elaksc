﻿using Microsoft.EntityFrameworkCore;
using Repositories.Context;
using Repositories.Contracts;
using System.Linq.Expressions;

namespace Repositories.EfCore
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly SimpDbContext _context;

        protected readonly DbSet<T> _entities;

        public Repository(SimpDbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public async Task AddAsync(T entity) => await _entities.AddAsync(entity);

        public void Update(T entity) => _context.Entry(entity).State = EntityState.Modified;

        public void Remove(T entity) => _entities.Remove(entity);

    
        public async Task<IEnumerable<T>> GetFilteredAsync(Expression<Func<T, bool>> filter)
        {
            return await _entities.Where(filter).ToListAsync();
        }
    }
}
