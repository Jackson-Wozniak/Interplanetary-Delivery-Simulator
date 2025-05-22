using interplanetary_delivery_simulator.planetary_resources.DTOs;
using interplanetary_delivery_simulator.planetary_resources.Service;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace interplanetary_delivery_simulator.planetary_resources.Controllers;

[Route("api/Planets")]
[ApiController]
public class PlanetController : ControllerBase
{
    private readonly PlanetService _planetService;

    public PlanetController(PlanetService planetService)
    {
        _planetService = planetService;
    }

    [HttpGet]
    public ActionResult<List<PlanetDTO>> GetAllPlanets()
    {
        return Ok(_planetService.FindAllPlanets());
    }
}