namespace Infrastructure.Data.Query.Queries.Entity.GetAllEntity;

public sealed class GetAllEntityQueryHandler(IEntityRepository _entityRepository) : IRequestHandler<GetAllEntityQuery, IEnumerable<GetAllEntityQueryResponse>>
{
    public async Task<IEnumerable<GetAllEntityQueryResponse>> Handle(GetAllEntityQuery request, CancellationToken cancellationToken)
    {
        var entities = await _entityRepository.GetAllAsync();

        return entities.Any()
            ? entities.Select(e => new GetAllEntityQueryResponse
            {
                Id = e.Id,
                Name = e.Name,
                Address = e.Address,
                CreatedDate = e.CreatedDate
            })
            : [];
    }
}
