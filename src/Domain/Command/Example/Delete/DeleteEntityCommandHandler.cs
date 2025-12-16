namespace Domain.Command.Example.Delete;

public class DeleteEntityCommandHandler(IEntityRepository _entityRepository) : IRequestHandler<DeleteEntityCommand>
{
    public async Task Handle(DeleteEntityCommand request, CancellationToken cancellationToken)
    {
        await _entityRepository.DeleteAsync(request.Id);
    }
}