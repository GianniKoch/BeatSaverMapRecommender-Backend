using Backend_API.Interfaces;
using Backend_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend_API.Controllers;

[ApiController]
[Route("[controller]")]
public class SectionController
{
    private readonly ISectionService sectionService;

    public SectionController(ISectionService sectionService)
    {
        this.sectionService = sectionService;
    }

    [HttpGet]
    public async Task<Section> NextSection()
    {
        return await sectionService.GetRandomSectionAsync();
    }
}