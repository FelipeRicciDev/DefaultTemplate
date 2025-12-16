namespace Domain.Command.Example.Create;

public class CreateEntityCommandHandler(
    IEntityRepository _entityRepository
    ) : IRequestHandler<CreateEntityCommand>
{
    public async Task Handle(CreateEntityCommand request, CancellationToken cancellationToken)
    {
        var entity = new EntityDB
        {
            Id = ObjectId.GenerateNewId().ToString(),
            Name = request.Name,
            Address = request.Address,
            CreatedDate = DateTime.UtcNow
        };

        await _entityRepository.AddAsync(entity);
    }
}
