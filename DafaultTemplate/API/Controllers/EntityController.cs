namespace API.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class EntityController(IMediator _mediator) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetAllAsync([FromQuery] GetAllEntityQuery getAllEntityQuery)
    {
        var getAllEntities = await _mediator.Send(getAllEntityQuery);
        return Ok(getAllEntities);
    }

    [HttpGet("{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetByIdAsync([FromRoute] string id)
    {
        var query = new GetEntityByIdQuery(id);

        var result = await _mediator.Send(query);

        return Ok(result);
    }

    [HttpPost]
    [ProducesResponseType((int)HttpStatusCode.Created)]
    public async Task<string> CreateAsync([FromBody] CreateEntityCommand createEntityCommand)
    {
        await _mediator.Send(createEntityCommand);
        return "ok";
    }

    [HttpPut]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<string> UpdateAsync([FromBody] UpdateEntityCommand updateEntityCommand)
    {
        await _mediator.Send(updateEntityCommand);
        return "ok";
    }

    [HttpDelete]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<string> DeleteAsync(DeleteEntityCommand deleteEntityCommand)
    {
        await _mediator.Send(deleteEntityCommand);
        return "ok";
    }
}
