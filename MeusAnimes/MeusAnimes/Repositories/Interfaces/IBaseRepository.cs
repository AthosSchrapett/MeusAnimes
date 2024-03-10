namespace MeusAnimes.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity, TKey>
        where TEntity : class
    {
        TEntity? GetById(TKey id);
        IEnumerable<TEntity>? GetAll();
        void Add(TEntity entity);
        void AddAll(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void RemoveAll(IEnumerable<TEntity> entities);
        TEntity? GetByCondition(Func<TEntity, bool> condition);
        IEnumerable<TEntity>? GetAllByCondition(Func<TEntity, bool> condition);
    }
}
