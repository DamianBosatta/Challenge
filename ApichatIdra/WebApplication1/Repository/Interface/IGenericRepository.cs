using System.Linq.Expressions;

namespace ApiChatIdra.Repository.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int? id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int? id);
        IEnumerable<T> find(Expression<Func<T, bool>> predicate);
    }
}
