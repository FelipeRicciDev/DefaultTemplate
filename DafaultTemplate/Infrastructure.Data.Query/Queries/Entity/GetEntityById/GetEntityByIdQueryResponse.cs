namespace Infrastructure.Data.Query.Queries.Entity.GetEntityById;

public sealed class GetEntityByIdQueryResponse
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public DateTime CreatedDate { get; set; }

    public static implicit operator GetEntityByIdQueryResponse(EntityDB entity)
    {
        if (entity is null) return new GetEntityByIdQueryResponse();

        return new()
        {
            Id = entity.Id,
            Name = entity.Name,
            Address = entity.Address,
            CreatedDate = entity.CreatedDate
        };
    }
}
