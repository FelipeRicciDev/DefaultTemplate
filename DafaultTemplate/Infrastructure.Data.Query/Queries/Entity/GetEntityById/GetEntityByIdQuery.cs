namespace Infrastructure.Data.Query.Queries.Entity.GetEntityById;

public class GetEntityByIdQuery(string id) : IRequest<GetEntityByIdQueryResponse>
{
    public string Id { get; set; } = id;
}
