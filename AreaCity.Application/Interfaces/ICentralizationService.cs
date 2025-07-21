using AreaCity.Application.DTOs;

namespace AreaCity.Application.Interfaces;
public interface ICentralizationService
{
	Task<CitiesResponse> GetCityAsync(string countryName);
}