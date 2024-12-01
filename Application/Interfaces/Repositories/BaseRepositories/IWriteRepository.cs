namespace Application.Interfaces.Repositories.BaseRepositories;

public interface IWriteRepository<T> where T : class
{
    /// <summary>
    /// Репозиторий для операций чтения
    /// </summary>
    IReadRepository<T> ReadRepository { get; }
    
    /// <summary>
    /// Метод для добавления сущности
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Метод для обновления сущности
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Метод для удаления сущности
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);
}