namespace Infrastructure.Data.Mongo.Repositories.v1.Entity;

public class EntityRepository(string collectionName) : MongoDbBaseRepository<EntityDB>(collectionName), IEntityRepository
{
    private readonly string _collection = collectionName;
    public async Task AddAsync(EntityDB entity)
    {
        var collection = Database.GetCollection<EntityDB>(_collection);
        await collection.InsertOneAsync(entity);
    }

    public async Task<bool> DeleteAsync(string id)
    {
        var collection = Database.GetCollection<EntityDB>(_collection);

        var filter = Builders<EntityDB>.Filter.Eq(x => x.Id, id);

        var result = await collection.DeleteOneAsync(filter);

        return result.DeletedCount > 0;
    }

    public async Task<IEnumerable<EntityDB>> GetAllAsync()
    {
        var collection = Database.GetCollection<EntityDB>(_collection);
        return await collection
            .Find(Builders<EntityDB>.Filter.Empty)
            .ToListAsync();
    }

    public async Task<EntityDB> GetByIdAsync(string id)
    {
        var collection = Database.GetCollection<EntityDB>(_collection);

        var filter = Builders<EntityDB>.Filter.Eq(x => x.Id, id);

        var entity = await collection
            .Find(filter)
            .FirstOrDefaultAsync();

        return entity;
    }

    public async Task UpdateAsync(EntityDB entity)
    {
        var collection = Database.GetCollection<EntityDB>(_collection);

        var filter = Builders<EntityDB>.Filter.Eq(x => x.Id, entity.Id);
        var updateSet = Builders<EntityDB>.Update
            .Set(x => x.Name, entity.Name)
            .Set(x => x.Address, entity.Address);

        await collection.UpdateOneAsync(filter, updateSet);
    }
}
