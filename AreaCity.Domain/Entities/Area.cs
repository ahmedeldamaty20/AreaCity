namespace AreaCity.Domain.Entities;
public class Area
{
	public CountryName Name { get; set; } = new();
	public string Status { get; set; } = string.Empty;
	public List<string> Capital { get; set; } = [];
}