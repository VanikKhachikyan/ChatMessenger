using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChatMessenger.Core.Interfaces.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class,IEntity
    {
        Task<ICollection<TEntity>> GetAllAsync();
        Task<TEntity> GetAsync(int entityId);
        Task<TEntity> Create(TEntity entity);
        Task Delete(int entity);
        void Delete(TEntity entity);
        void UpDate(TEntity entity);
    }
}
