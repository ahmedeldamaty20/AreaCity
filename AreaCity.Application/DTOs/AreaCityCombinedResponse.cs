using AreaCity.Domain.Entities;

namespace AreaCity.Application.DTOs;
public class AreaCityCombinedResponse
{
	public CountryName AreaName { get; set; } = new();
	public string Status { get; set; } = string.Empty;
	public List<string> Capital { get; set; } = [];
	public List<string> Data { get; set; } = [];
}