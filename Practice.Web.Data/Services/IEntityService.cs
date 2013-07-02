using Practice.Web.Data.Entities;

namespace Practice.Web.Data.Services
{
    public interface IEntityService<T> where T:IMongoEntity
    {
        void Create(T entity);
        void Delete(string id);
        T GetId(string id);
        void Update(T entity);
    }
}
