namespace Infrastructure.Data.Query.Queries.Entity.GetEntityById;

public sealed class GetEntityByIdQueryHandler(IEntityRepository _entityRepository) : IRequestHandler<GetEntityByIdQuery, GetEntityByIdQueryResponse>
{
    public async Task<GetEntityByIdQueryResponse> Handle(GetEntityByIdQuery request, CancellationToken cancellationToken)
    {
		try
		{
            var entity = await _entityRepository.GetByIdAsync(request.Id);

            return (GetEntityByIdQueryResponse)entity;
        }
        catch (Exception)
        {
            throw new Exception($"Error on Get By Id {request.Id}");
        }
    }
}
