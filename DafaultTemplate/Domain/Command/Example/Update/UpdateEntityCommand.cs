namespace Domain.Command.Example.Update;

public sealed class UpdateEntityCommand : IRequest
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}
