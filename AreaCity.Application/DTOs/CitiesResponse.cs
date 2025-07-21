namespace AreaCity.Application.DTOs;
public class CitiesResponse
{
	public bool Error { get; set; }
	public string Msg { get; set; } = string.Empty;
	public List<string> Data { get; set; } = [];
}