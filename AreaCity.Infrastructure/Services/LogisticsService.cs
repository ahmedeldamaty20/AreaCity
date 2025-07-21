using AreaCity.Application.Interfaces;
using AreaCity.Domain.Entities;
using System.Net.Http.Json;

namespace AreaCity.Infrastructure.Services;
public class LogisticsService : ILogisticsService
{
	private readonly HttpClient _httpClient;

	public LogisticsService(HttpClient httpClient)
	{
		_httpClient = httpClient;
		_httpClient.BaseAddress = new Uri("https://restcountries.com/v3.1/name/");
	}

	public async Task<List<Area>?> GetAreaAsync(string areaName)
	{
		var response = await _httpClient.GetAsync(areaName);
		response.EnsureSuccessStatusCode();

		return await response.Content.ReadFromJsonAsync<List<Area>>();
	}
}