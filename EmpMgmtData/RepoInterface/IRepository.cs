using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmtData.RepoInterface
{
    /// <summary>
    /// This interface would describe all the methods in IRepository
    ///Interface repository for base abstract class.
    /// </summary>
    /// <remarks>
    /// Each method or property
    /// in this IRepository interface would contain docs that you want
    /// to duplicate in each implementing class. 
    /// </remarks>
    public interface IRepository<T> where T : class
    {
        //Returns data based on given id
        T Get(int id);

        //Returns all data
        IEnumerable<T> GetAll();

        //Returns data for matched expression
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        //Adds an object to entities collection.
        void Add(T entity);

        //Adds the elements of the specified collection to the end of the List.
        void AddRange(IEnumerable<T> entities);

        //Removes an object from entities collection.
        void Remove(T entity);

        //Removes a range of elements from List.
        void RemoveRange(IEnumerable<T> entities);

        /*Start using async methods*/

        IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);

        Task<T> AddAsync(T t);

        Task<int> CountAsync();

        Task<int> DeleteAsync(T entity);

        Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match);

        Task<T> FindAsync(Expression<Func<T, bool>> match);

        Task<ICollection<T>> FindByAsync(Expression<Func<T, bool>> predicate);

        Task<ICollection<T>> GetAllAsync();

        Task<T> GetAsync(int id);

        Task<T> UpdateAsync(T t, object key);

        IQueryable<T> QueryAll();
    }
}
