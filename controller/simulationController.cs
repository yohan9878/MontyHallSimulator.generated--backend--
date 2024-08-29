using Microsoft.AspNetCore.Mvc;

[Route("api/")]
[ApiController]
public class MontyHallController : ControllerBase
{
    private readonly MontyHallService _montyHallService;

    public MontyHallController(MontyHallService montyHallService)
    {
        _montyHallService = montyHallService;
    }

    [HttpPost("/simulate")]
    public IActionResult Simulate([FromBody] SimulationRequest request)
    {
        var result = _montyHallService.SimulateGames(request.NumSimulations, request.SwitchDoor);
        return Ok(result);
    }
}

public class SimulationRequest
{
    public int NumSimulations { get; set; }
    public bool SwitchDoor { get; set; }
}




