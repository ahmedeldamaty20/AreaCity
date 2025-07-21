namespace AreaCity.Domain.Entities;
public class City
{
	public int CityId { get; set; }
	public string Name { get; set; } = string.Empty;
	public string Governorate { get; set; } = string.Empty;
	public string Region { get; set; } = string.Empty;
}