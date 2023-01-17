using Backend_API.Interfaces;
using Backend_API.Models;

namespace Backend_API.Services;

public class SectionService: ISectionService
{
    public async Task<Section> GetRandomSectionAsync()
    {
        
        return new Section();
    }
}