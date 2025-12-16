namespace Domain.Command.Example.Delete;

public sealed class DeleteEntityCommand : IRequest
{
    public string Id { get; set; }
}
