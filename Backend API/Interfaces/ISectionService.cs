using Persistence.Models;

namespace Backend_API.Interfaces;

public interface ISectionService
{
    Task<Section> GetRandomSectionAsync();
    Task AddTagValues(TagValuesResponse response);
    Task<List<TagValuesResponse>> GetAllSections();
}