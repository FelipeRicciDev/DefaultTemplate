namespace Domain.Command.Example.Create;

public class CreateEntityCommand : IRequest
{
    public string Name { get; set; }
    public string Address { get; set; }
}