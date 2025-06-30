using Microsoft.EntityFrameworkCore.Storage;
using SchoolProject.Data;
using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrastructure.InfrastructureBases
{
    public interface IGenericRepositoryAsync<T>where T :class
    {
        public Task<T> AddAsync(T entity);
        public Task AddRangeAsync (ICollection<T> entities);
        public Task UpdateAsync(T entity);
        public Task UpdateRangeAsync(ICollection<T> entities);
        public Task DeleteAsync(T entity);
        public Task DeleteRangeAsync(ICollection<T> entities);
        public Task<T> GetByIdAsync(int id);
        public Task SaveChangesAsync();
        public IQueryable<T> GetTableAsTracking();
        public IQueryable<T> GetTableNoTracking();
        public IDbContextTransaction BeginTransaction();
        public void Commit();
        public void Rollback();

    }
}
