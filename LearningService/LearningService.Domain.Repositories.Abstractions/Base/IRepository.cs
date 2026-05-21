namespace LearningService.Domain.Repositories.Abstractions.Base;

public interface IRepository<TEntity, TId>
{
    Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken);

    Task<TEntity?> GetByIdAsync(TId id, CancellationToken cancellationToken);

    Task<TEntity?> AddAsync(TEntity entity, CancellationToken cancellationToken);

    Task<bool> UpdateAsync(TEntity entity, CancellationToken cancellationToken);

    Task<bool> DeleteAsync(TId id, CancellationToken cancellationToken);
}
