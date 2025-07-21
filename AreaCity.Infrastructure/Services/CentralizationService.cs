using AreaCity.Application.Interfaces;
using System.Net.Http.Json;
using AreaCity.Application.DTOs;

namespace AreaCity.Infrastructure.Services;
public class CentralizationService(HttpClient httpClient) : ICentralizationService
{
	public async Task<CitiesResponse> GetCityAsync(string countryName)
	{
		var request = new CountryNameRequest { Country = countryName };

		var response = await httpClient.PostAsJsonAsync("https://countriesnow.space/api/v0.1/countries/cities", request);

		if (!response.IsSuccessStatusCode)
		{
			throw new HttpRequestException($"Error fetching city data: {response.ReasonPhrase}");
		}

		var cities = await response.Content.ReadFromJsonAsync<CitiesResponse>();

		return cities;
	}
}