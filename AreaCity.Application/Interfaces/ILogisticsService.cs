using AreaCity.Domain.Entities;

namespace AreaCity.Application.Interfaces;
public interface ILogisticsService
{
	Task<List<Area>?> GetAreaAsync(string areaName);
}