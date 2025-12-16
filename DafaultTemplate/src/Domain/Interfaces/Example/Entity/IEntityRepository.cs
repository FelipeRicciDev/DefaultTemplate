namespace Domain.Interfaces.Example.Entity;

public interface IEntityRepository
{
    Task AddAsync(EntityDB entity);
    Task<bool> DeleteAsync(string id);
    Task UpdateAsync(EntityDB EntityDB);
    Task<IEnumerable<EntityDB>> GetAllAsync();
    Task<EntityDB> GetByIdAsync(string id);
}
