using MeusAnimes.Data;
using MeusAnimes.Interfaces.Repositories;

namespace MeusAnimes.Repositories.Implementations;

public class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey>
    where TEntity : class
{
    protected readonly MeusAnimesContext _meusAnimesContext;

    public BaseRepository(MeusAnimesContext meusAnimesContext) => _meusAnimesContext = meusAnimesContext;

    public virtual IEnumerable<TEntity>? GetAll() => _meusAnimesContext.Set<TEntity>();
    public virtual TEntity? GetById(TKey id) => _meusAnimesContext.Set<TEntity>().Find(id);
    public virtual void Add(TEntity entity)
    {
        _meusAnimesContext.Set<TEntity>().Add(entity);
        _meusAnimesContext.SaveChanges();
    }

    public virtual void AddAll(IEnumerable<TEntity> entities) => _meusAnimesContext.Set<TEntity>().AddRange(entities);
    public virtual void Delete(TEntity entity) => _meusAnimesContext.Set<TEntity>().Remove(entity);
    public virtual void RemoveAll(IEnumerable<TEntity> entities) => _meusAnimesContext.RemoveRange(entities);
    public virtual void Update(TEntity entity) => _meusAnimesContext.Set<TEntity>().Update(entity);
    public virtual TEntity? GetByCondition(Func<TEntity, bool> condition) => _meusAnimesContext.Set<TEntity>().FirstOrDefault(condition);
    public virtual IEnumerable<TEntity>? GetAllByCondition(Func<TEntity, bool> condition) => _meusAnimesContext.Set<TEntity>().Where(condition);
}
