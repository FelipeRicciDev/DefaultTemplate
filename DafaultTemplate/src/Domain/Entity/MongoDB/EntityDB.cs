namespace Domain.Entity.MongoDB;

public sealed class EntityDB
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = default!;
    [BsonElement("name")]
    public string Name { get; set; }

    [BsonElement("address")]
    public string Address { get; set; }

    [BsonElement("createdDate")]
    public DateTime CreatedDate { get; set; }
}
