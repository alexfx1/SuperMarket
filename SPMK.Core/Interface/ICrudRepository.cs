using SPMK.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMK.Core.Interface
{
    public interface ICrudReporitory<T> : IDisposable where T : BaseEntity
    {
        Task<T> GetById(string id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAllPaginated(int page, int quantityPerPage, string orderBy, string sortBy = "ASC");
        Task<T> Create(T entity);
        Task<T> DeleteById(string id);
        Task<T> UpdateById(string id, T updatedEntity);
    }
}
