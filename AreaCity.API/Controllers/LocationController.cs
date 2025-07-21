using AreaCity.Application.DTOs;
using AreaCity.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AreaCity.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LocationController(IMediator mediator) : ControllerBase
{
	[HttpGet("combined-info")]
	public async Task<ActionResult<AreaCityCombinedResponse>> GetCombinedInfo([FromQuery] string? countryName)
	{
		var query = new GetAreaCityInfoQuery { CountryName = countryName };
		var result = await mediator.Send(query);
		return Ok(result);
	}
}