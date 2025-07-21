using AreaCity.Application.DTOs;
using MediatR;

namespace AreaCity.Application.Queries;
public class GetAreaCityInfoQuery : IRequest<AreaCityCombinedResponse>
{
	public string? CountryName { get; set; }
}