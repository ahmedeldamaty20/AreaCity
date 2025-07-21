using AreaCity.Application.DTOs;
using AreaCity.Application.Interfaces;
using AreaCity.Application.Queries;
using MediatR;

namespace AreaCity.Application.Handlers;
public class GetAreaCityInfoQueryHandler(ILogisticsService logisticsService, ICentralizationService centralizationService) : IRequestHandler<GetAreaCityInfoQuery, AreaCityCombinedResponse>
{
	public async Task<AreaCityCombinedResponse> Handle(GetAreaCityInfoQuery request, CancellationToken cancellationToken)
	{
		var result = new AreaCityCombinedResponse();

		if (string.IsNullOrEmpty(request.CountryName) is false)
		{
			var areas = await logisticsService.GetAreaAsync(request.CountryName);

			var area = areas?.FirstOrDefault();

			if (area is not null)
			{
				result.AreaName = area.Name;
				result.Capital = area.Capital;
				result.Status = area.Status;
			}

			var cities = await centralizationService.GetCityAsync(request.CountryName);

			result.Data = cities?.Data != null ? cities.Data : [];
		}

		return result;
	}
}