namespace Domain.Command.Example.Update;

public class UpdateEntityCommandHandler(IEntityRepository _entityRepository) : IRequestHandler<UpdateEntityCommand>
{
    public async Task Handle(UpdateEntityCommand request, CancellationToken cancellationToken)
    {
        var obj = new EntityDB
        {
            Id = request.Id,
            Name = request.Name,
            Address = request.Address
        };

        await _entityRepository.UpdateAsync(obj);
    }
}

